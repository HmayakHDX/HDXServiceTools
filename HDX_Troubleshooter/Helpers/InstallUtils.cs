using System.Diagnostics;
using System.IO.Compression;
using System.Net.Sockets;

namespace HDX_ServiceTools.Helpers
{
    public static class InstallUtils
    {
        private static readonly HttpClient httpClient = new();

        public static async Task DownloadFileAsync(
            string url,
            string outputPath,
            Action<string> updateStatus,
            IProgress<int> progress,
            CancellationToken token)
        {
            Logger.LogAndUpdate($"Starting download...\r\nAttempting download to: {outputPath}", updateStatus);

            try
            {
                // Send a GET request to the given URL and only read headers initially
                using var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, token);

                // Ensure the HTTP response indicates success (e.g., 200 OK). If not, throw an exception.
                response.EnsureSuccessStatusCode();

                // Try to get the Content-Length header, and use it if it's available
                long totalBytes = response.Content.Headers.ContentLength ?? -1;
                bool canReportProgress = totalBytes > 0;

                // Get the content as a stream so we can read it in chunks (efficient for large files)
                using var contentStream = await response.Content.ReadAsStreamAsync(token);

                // Open a file stream to write the downloaded data to disk
                using var fileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None);

                // Define a buffer to hold chunks of data as we read them from the server
                var buffer = new byte[8192]; // 8KB buffer
                long totalRead = 0;          // Tracks how much data we've read
                int bytesRead;               // Number of bytes read in the last chunk

                // Read the content in chunks until there’s nothing left to read
                while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length, token)) > 0)
                {
                    // Write the chunk to the file on disk
                    await fileStream.WriteAsync(buffer, 0, bytesRead, token);

                    // Track the total number of bytes read so far
                    totalRead += bytesRead;

                    // If possible, calculate and report the download progress
                    ReportProgress(totalRead, totalBytes, progress);
                }

                Logger.LogAndUpdate("Download complete.", updateStatus);
            }
            catch (OperationCanceledException ex)
            {
                // Catches cancellation via CancellationToken — e.g., user clicked cancel
                Logger.LogException("Download canceled by user", ex, updateStatus);

                // Attempt to delete any partially downloaded file
                TryDelete("downloaded", outputPath, updateStatus);

                // Rethrow to let calling code know it was a cancellation
                throw;
            }
            catch (HttpRequestException ex) when (ex.InnerException is SocketException socketEx)
            {
                // Catches network-level issues like DNS failure or no connectivity
                // and distinguishes the specific cause using the SocketErrorCode
                string errorMsg = socketEx.SocketErrorCode switch
                {
                    SocketError.HostNotFound => "Network error: Host not found (DNS resolution failed)",
                    SocketError.NetworkUnreachable => "Network error: Network unreachable (PC may be offline)",
                    SocketError.HostUnreachable => "Network error: Host unreachable (server unreachable)",
                    _ => $"Socket error ({socketEx.SocketErrorCode})"
                };

                Logger.LogException(errorMsg, ex, updateStatus);
                TryDelete("downloaded", outputPath, updateStatus);
            }
            catch (HttpRequestException ex)
            {
                // Catches HTTP protocol issues (non-success status codes, connection refused, etc.)
                Logger.LogException("HTTP request failed", ex, updateStatus);
                TryDelete("downloaded", outputPath, updateStatus);
            }
            catch (IOException ex)
            {
                // Catches file system issues (disk full, access denied, file locked, etc.)
                Logger.LogException("File I/O error during download", ex, updateStatus);
                TryDelete("downloaded", outputPath, updateStatus);
            }
            catch (Exception ex)
            {
                // Catches all other unexpected exceptions
                Logger.LogException("Unexpected error during download", ex, updateStatus);
                TryDelete("downloaded", outputPath, updateStatus);
            }
        }

        public static async Task ExtractZipAsync(
            string zipPath,
            string extractToPath,
            Action<string> updateStatus,
            IProgress<int> progress,
            CancellationToken token)
        {
            Logger.LogAndUpdate($"Starting extraction...", updateStatus);

            try
            {
                // If the extraction directory already exists, delete it to start fresh
                if (Directory.Exists(extractToPath))
                {
                    Directory.Delete(extractToPath, true);
                }

                // Recreate the target directory
                Directory.CreateDirectory(extractToPath);

                // Open the ZIP archive for reading
                using var archive = ZipFile.OpenRead(zipPath);

                int totalEntries = archive.Entries.Count; // Total number of files/folders to extract
                int extractedCount = 0; // Tracks how many have been extracted so far

                Logger.LogAndUpdate($"Attempting extraction to: {extractToPath}", updateStatus);

                // Iterate over every entry (file or folder) in the ZIP archive
                foreach (var entry in archive.Entries)
                {
                    // Allow cancellation if requested
                    token.ThrowIfCancellationRequested();

                    // Determine the full destination path for this entry
                    string destinationPath = Path.Combine(extractToPath, entry.FullName);

                    // Create the parent directory if needed
                    string? directoryPath = Path.GetDirectoryName(destinationPath);
                    if (!string.IsNullOrEmpty(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    // If entry is a directory, skip file writing — it's already handled by CreateDirectory
                    if (string.IsNullOrEmpty(entry.Name)) continue;

                    // Open the entry's stream (read from ZIP)
                    using var entryStream = entry.Open();

                    // Create a file stream to write it to disk
                    using var fileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None);

                    // Copy the data from the ZIP to the output file
                    await entryStream.CopyToAsync(fileStream, cancellationToken: token);

                    // Update progress
                    extractedCount++;
                    int percent = (int)((extractedCount * 100.0) / totalEntries);
                    progress.Report(percent); // Triggers UI updates like progress bars
                }

                Logger.LogAndUpdate("Extraction complete.", updateStatus);
            }
            catch (OperationCanceledException ex)
            {
                // Handle user-initiated cancellation
                Logger.LogException("Extraction canceled by user", ex, updateStatus);

                // Clean up any partial files
                TryDelete("extracted", extractToPath, updateStatus);
                TryDelete("downloaded", zipPath, updateStatus);
                throw;
            }
            catch (Exception ex)
            {
                // Handle all other extraction errors (e.g., corrupted ZIP, disk issues)
                Logger.LogException("Failed to extract ZIP file.", ex, updateStatus);

                // Clean up
                TryDelete("extracted", extractToPath, updateStatus);
                TryDelete("downloaded", zipPath, updateStatus);
                throw;
            }
        }

        // TODO: Restructure exception handling to account for already installed components
        // ---> requires additional testing to ensure no false positives or incomplete installations
        public static async Task RunInstallerAsync(
            string filePath,
            string arguments,
            Action<string> updateStatus,
            CancellationToken token)
        {
            try
            {
                string installerName = Path.GetFileName(filePath);

                // Notify user/UI that the installer is starting
                updateStatus($"Starting installer: {installerName}");
                Logger.LogAndUpdate($"Executing: {filePath} {arguments}", updateStatus);

                // Configure and launch the external process (installer)
                using var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = filePath,               // Installer path (e.g. *.exe or msiexec)
                        Arguments = arguments,             // Installer flags (e.g. /q, /silent, etc.)
                        UseShellExecute = false,           // Must be false to allow redirection
                        CreateNoWindow = true,             // Prevents command prompt window from showing
                        RedirectStandardOutput = true,     // Capture stdout for logs
                        RedirectStandardError = true       // Capture stderr for logs
                    },
                    EnableRaisingEvents = true             // Required to await exit event
                };

                // TaskCompletionSource to await process exit
                var tcs = new TaskCompletionSource<bool>();

                // Signal task completion when process exits
                process.Exited += (_, _) => tcs.TrySetResult(true);

                // Start the process
                process.Start();

                // OPTIONAL: Asynchronously capture output and error logs
                _ = Task.Run(async () =>
                {
                    string? stdout = await process.StandardOutput.ReadToEndAsync();
                    string? stderr = await process.StandardError.ReadToEndAsync();

                    if (!string.IsNullOrWhiteSpace(stdout))
                        Logger.Write($"[{installerName}] STDOUT: {stdout}");

                    if (!string.IsNullOrWhiteSpace(stderr))
                        Logger.Write($"[{installerName}] STDERR: {stderr}");
                });

                // Handle cancellation using the provided token
                using (token.Register(() => tcs.TrySetCanceled()))
                {
                    await tcs.Task; // Await process exit
                }

                // If the installer failed (non-zero exit code), throw an exception
                if (process.ExitCode != 0)
                {
                    throw new Exception($"Installer exited with code {process.ExitCode}");
                }

                // Notify success
                updateStatus($"{installerName} installed.");
                Logger.LogAndUpdate($"Finished installer: {installerName}", updateStatus);
            }
            catch (OperationCanceledException)
            {
                // Log cancellation separately
                updateStatus("Installation canceled by user.");
                Logger.Write($"Installation canceled: {filePath}");
                throw;
            }
            catch (Exception ex)
            {
                // Log general failure
                updateStatus($"Failed to install: {Path.GetFileName(filePath)}");
                Logger.LogException($"Error running installer: {filePath}", ex, updateStatus);
                throw;
            }
        }

        /// <summary>
        /// Calculates and reports the download progress as a percentage (0–100).
        /// </summary>
        private static void ReportProgress(long bytesRead, long totalBytes, IProgress<int> progress)
        {
            if (totalBytes > 0)
            {
                int percent = (int)((bytesRead * 100) / totalBytes);
                progress.Report(percent); // Triggers the callback, e.g., to update the UI
            }
        }

        /// <summary>
        /// Attempts to delete the specified file if it exists. Logs success or failure.
        /// </summary>
        public static void TryDelete(string context, string path, Action<string> updateStatus)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    Logger.LogAndUpdate($"Successfully deleted {context} files", updateStatus);
                }
            }
            catch (Exception ex)
            {
                Logger.LogException($"Failed to delete {context} files", ex, updateStatus);
            }
        }
    }
}
