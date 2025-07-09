namespace HDX_ServiceTools.Helpers
{
    /// <summary>
    /// Logger is responsible for writing timestamped messages to a session-based log file
    /// stored under C:\Will-Master\Log\ServiceTool
    /// It also provides helper methods for logging messages while updating the UI via a delegate
    /// </summary>
    internal static class Logger
    {
        // The full path to the log file for the current session
        private static readonly string logPath;

        // Static constructor: runs only once when the Logger class is first accessed
        static Logger()
        {
            // Define the log directory path
            string logDirectory = @"C:\Will-Master\Log\ServiceTool";

            // Create the directory if it doesn't already exist (safe to call repeatedly)
            Directory.CreateDirectory(logDirectory);

            // Generate a unique timestamp-based filename (e.g., log_20250702_213045.txt)
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            // Combine the directory and filename to form the full log file path
            logPath = Path.Combine(logDirectory, $"log_{timestamp}.txt");

            // Write an initial entry to the log when the session begins
            Write("=== New session started ===");
        }

        public static string LogPath => logPath;

        /// <summary>
        /// Appends a message to the log file with a timestamp prefix.
        /// </summary>
        /// <param name="message">The message to write to the log file</param>
        public static void Write(string message)
        {
            File.AppendAllText(logPath, $"{DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}");
        }

        /// <summary>
        /// Sends a message to both the UI (via updateStatus) and to the log file.
        /// This is useful to keep the user informed while maintaining a persistent log.
        /// </summary>
        /// <param name="message">The status or log message to display and save</param>
        /// <param name="updateStatus">
        /// Delegate (Action<string>) that updates the UI with the message.
        /// If null, only the log file is written to.
        /// </param>
        public static void LogAndUpdate(string message, Action<string> updateStatus)
        {
            // Safely call the updateStatus delegate with the given message.
            // The ?. operator ensures we only try to call it if it's not null.
            // This prevents a NullReferenceException if updateStatus was not provided.
            //
            // updateStatus is expected to be a method like: void UpdateUI(string message)
            // and is typically passed from the form to display status updates in a TextBox or Label.
            updateStatus?.Invoke(message);

            // Write the same message to the log file
            Write(message);
        }

        /// <summary>
        /// Logs an exception message and optionally updates the UI with context.
        /// This makes it easy to log detailed error messages from a catch block.
        /// </summary>
        /// <param name="contextMessage">A short description of what was happening</param>
        /// <param name="ex">The exception that was caught</param>
        /// <param name="updateStatus">
        /// An optional delegate for updating the UI with the combined error message.
        /// </param>
        public static void LogException(string contextMessage, Exception ex, Action<string>? updateStatus)
        {
            // Combine the context message and exception message into one string
            string fullMessage = $"{contextMessage}: {ex.Message}";

            // Display to the user if a delegate is provided
            updateStatus?.Invoke(fullMessage);

            // Always log the error to the log file
            Write(fullMessage);
        }
    }
}