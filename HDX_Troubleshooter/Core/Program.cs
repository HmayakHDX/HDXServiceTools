using HDX_ServiceTools.Forms;
using System.Diagnostics;
using System.Security.Principal;

namespace HDX_ServiceTools.Core
{
    internal static class Program
    {
        // Unique identifier for the single-instance mutex
        private static readonly string MutexName = "HDX_ServiceTools_SingleInstance";

        [STAThread]
        static void Main()
        {
            // Attempt to create a system-wide mutex to prevent multiple instances
            using var mutex = new Mutex(true, MutexName, out bool isNewInstance);

            if (!isNewInstance)
            {
                // If another instance is already running, exit
                MessageBox.Show("Another instance of this application is already running.",
                                "Instance Already Running",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            // Check if current process is running with admin privileges
            if (!IsRunningAsAdministrator())
            {
                try
                {
                    // Relaunch the application with elevated (admin) privileges
                    string exePath = Process.GetCurrentProcess().MainModule?.FileName ?? string.Empty;

                    var startInfo = new ProcessStartInfo(exePath)
                    {
                        UseShellExecute = true,
                        Verb = "runas" // Triggers UAC prompt
                    };

                    Process.Start(startInfo);
                }
                catch
                {
                    // If the user cancels or UAC fails, exit
                    MessageBox.Show("Administrator privileges are required to run this application.",
                                    "Permission Denied",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                // Always exit the non-elevated process
                return;
            }

            // At this point: we have a single instance AND elevated privileges
            ApplicationConfiguration.Initialize();

            EntryForm form = new();
            FormManager.RegisterEntryForm(form);

            Application.Run(form);
        }

        /// <summary>
        /// Determines whether the current process is running as an administrator.
        /// </summary>
        private static bool IsRunningAsAdministrator()
        {
            using var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}