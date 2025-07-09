using HDX_ServiceTools.Helpers;

namespace HDX_ServiceTools.InstallHandlers
{
    internal class WMODHandler : IInstallHandler
    {
        public async Task HandleAsync(Action<string> updateStatus, IProgress<int> progress, CancellationToken token)
        {
            // START DEMO
            // Simulate installation, extraction, and installation process with empty await statements and progress bar updates/resets
            // Also simulates cancelling process if user attempts to close window mid-installation

            try
            {
                Logger.LogAndUpdate("Simulating download....", updateStatus);

                for (int i = 1; i <= 10; i++)
                {
                    await Task.Delay(1000, token);
                    progress.Report(i * 10);
                }

                Logger.LogAndUpdate("Download successful.", updateStatus);

                progress.Report(0);

                Logger.LogAndUpdate("Simulating extraction....", updateStatus);

                for (int j = 1; j <= 10; j++)
                {
                    await Task.Delay(1000, token);
                    progress.Report(j * 10);
                }

                Logger.LogAndUpdate("Extraction successful.", updateStatus);

                progress.Report(0);

                Logger.LogAndUpdate("Simulating installation....", updateStatus);

                for (int k = 1; k <= 10; k++)
                {
                    await Task.Delay(1000, token);
                    progress.Report(k * 10);
                }

                Logger.LogAndUpdate("Installation has been completed.", updateStatus);
            }
            catch (OperationCanceledException ex)
            {
                // Catches cancellation via CancellationToken — e.g., user clicked cancel
                Logger.LogAndUpdate("Installation cancelled by user.", updateStatus);
                Logger.LogAndUpdate("Cleaning up temporary files...", updateStatus);
                await Task.Delay(5000, CancellationToken.None);
            }

            // END DEMO

            /*string url = "https://www.dropbox.com/scl/fi/dsksvdpx6z3fhxqvgtzc6/Will-Master_OnDemand_InstallPackage.zip?rlkey=u2o2h3h9n96134rr5kr83trkm&st=o39qicgt&dl=1";
            
            string downloadPath = Path.Combine(Path.GetTempPath(), "hdx_temp_install.zip");
            string extractPath = Path.Combine(Path.GetTempPath(), "hdx_temp_extract");
            string installPath = Path.Combine(extractPath, "Will-Master_OnDemand_InstallPackage");

            int totalSteps = 31;
            int completedSteps = 0;

            List<string> failedInstallers = [];

            var installSequence = new List<(string fileName, string args)>
            {
                ("Will-Master_Client_Setup_240524.exe", "/q"),
                ("redistservicepack23.exe", "/Q"),
                ("redistservicepack24.exe", "/Q"),
                ("VC_redist.x64.exe", "/q /NORESTART"),
                ("haspdinst.exe", "/i -nomsg"),
                ("accessdatabaseengine_X64.exe", "/q /NORESTART"),
                ("MicrosoftEdgeWebView2RuntimeInstallerX64.exe", "/silent /install"),
                ("OnDemand3DApp_x64_1.0.11.1007.083123.exe", "/q")
            };

            // TODO: Make the entire process into a single try/catch, current version will continue even if download fails.
            // have each utility task report themselves to know where failure occurred at upper levels
            // (DownloadFileAsync throws/reports that it failed during download stage, along with why)

            // Step 1: Download
            try
            {
                await InstallUtils.DownloadFileAsync(
                    url,
                    downloadPath,
                    updateStatus,
                    progress,
                    token
                );
            }
            catch (Exception ex)
            {
                Logger.LogException("Download unsuccessful", ex, updateStatus);
                throw;
            }

            progress.Report(0);

            // Step 2: Extract
            try
            {
                await InstallUtils.ExtractZipAsync(downloadPath, extractPath, updateStatus, progress, token);

                // Clean up zip after successful extraction
                InstallUtils.TryDelete("downloaded", downloadPath, updateStatus);
            }
            catch (Exception ex)
            {
                Logger.LogException("Extraction unsuccessful", ex, updateStatus);
                throw;
            }

            progress.Report(0);

            // Step 3: Installation
            foreach (string vcFile in Directory.GetFiles(installPath, "vcredist*.exe"))
            {
                string fileName = Path.GetFileName(vcFile);

                try
                {
                    await InstallUtils.RunInstallerAsync(vcFile, "/Q /NORESTART", updateStatus, token);
                }
                catch (Exception ex)
                {
                    Logger.LogException($"vcredist failed: {fileName}", ex, updateStatus);
                    failedInstallers.Add(fileName);
                }

                completedSteps++;
                progress.Report((int)((completedSteps * 100.0) / totalSteps));
            }

            foreach (var (fileName, args) in installSequence)
            {
                string fullPath = Path.Combine(installPath, fileName);

                try
                {
                    await InstallUtils.RunInstallerAsync(fullPath, args, updateStatus, token);
                }
                catch (Exception ex)
                {
                    Logger.LogException($"Installer failed: {fileName}", ex, updateStatus);
                    failedInstallers.Add(fileName);
                }

                completedSteps++;
                progress.Report((int)((completedSteps * 100.0) / totalSteps));
            }

            try
            {
                string msiPath = Path.Combine(installPath, "WillMaster_Update_3.14.2023.msi");

                await InstallUtils.RunInstallerAsync(
                    "msiexec",
                    $"/i \"{msiPath}\" /passive /norestart",
                    updateStatus,
                    token
                );
            }
            catch (Exception ex)
            {
                Logger.LogException("MSI installation failed", ex, updateStatus);
                failedInstallers.Add("WillMaster_Update_3.14.2023.msi");
            }

            completedSteps++;
            progress.Report((int)((completedSteps * 100.0) / totalSteps));

            // STEP 5 — Final Summary
            if (failedInstallers.Count == 0)
            {
                updateStatus("All components installed successfully.");
                Logger.Write("Installation completed with no errors.");
            }
            else
            {
                updateStatus($"{failedInstallers.Count} installer(s) failed:");
                foreach (var fail in failedInstallers)
                {
                    updateStatus($"   - {fail}");
                }

                Logger.Write($"Installation completed with {failedInstallers.Count} failure(s).");
            }*/
        }
    }
}