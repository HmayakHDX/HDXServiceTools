using System.ServiceProcess;

namespace HDX_ServiceTools.Helpers
{
    public static class ServiceUtils
    {
        // TODO: Implement logic to check dongle through Sentinel API & system resources (if possible)
        // ---> to avoid user prompts and make it more automated (prompt for dongle if checks fail)
        public static bool TryVerifyDongle(Action<string> updateStatus)
        {
            Logger.LogAndUpdate("Checking if license key is connected and enabled...", updateStatus);

            DialogResult result = MessageBox.Show(
                "Is the physical license key (red USB) connected to the computer?",
                "USB Connected?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.Yes)
            {
                Logger.LogAndUpdate("License key reported as CONNECTED.", updateStatus);

                result = MessageBox.Show(
                    "Is there a blinking light on the license key?",
                    "USB Enabled?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    Logger.LogAndUpdate("License key reported as ENABLED.", updateStatus);
                    return true;
                }

                Logger.LogAndUpdate("License key reported as DISABLED.", updateStatus);
                return false;
            }

            Logger.LogAndUpdate("License key reported as DISCONNECTED.", updateStatus);
            return false;
        }

        public static bool TryVerifyService(string serviceName, Action<string> updateStatus)
        {
            try
            {
                // Check if the service exists first
                bool serviceExists = ServiceController.GetServices()
                    .Any(s => string.Equals(s.ServiceName, serviceName, StringComparison.OrdinalIgnoreCase));

                if (!serviceExists)
                {
                    Logger.LogAndUpdate($"Service '{serviceName}' was not found on this system.", updateStatus);
                    return false;
                }

                ServiceController sc = new(serviceName);
                Logger.LogAndUpdate($"Current status of {sc.DisplayName}: {sc.Status}", updateStatus);

                return sc.Status switch
                {
                    ServiceControllerStatus.Stopped => TryStartService(sc, updateStatus),
                    ServiceControllerStatus.Running =>
                        TryStopService(sc, updateStatus) && TryStartService(sc, updateStatus),
                    ServiceControllerStatus.Paused => TryStartService(sc, updateStatus),
                    _ => LogUnexpectedState(sc, updateStatus)
                };
            }
            catch (Exception ex)
            {
                Logger.LogException("Error while handling the service", ex, updateStatus);
                return false;
            }
        }

        private static bool LogUnexpectedState(ServiceController sc, Action<string> updateStatus)
        {
            Logger.LogAndUpdate($"{sc.DisplayName} is in an unexpected state: {sc.Status}", updateStatus);
            return false;
        }

        private static bool TryStartService(ServiceController sc, Action<string> updateStatus)
        {
            try
            {
                sc.Start();
                sc.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
                sc.Refresh();

                if (sc.Status == ServiceControllerStatus.Running)
                {
                    Logger.LogAndUpdate($"{sc.DisplayName} started successfully.", updateStatus);
                    return true;
                }

                Logger.LogAndUpdate($"Failed to start {sc.DisplayName} within the expected time.", updateStatus);
                return false;
            }
            catch (Exception ex)
            {
                Logger.LogException($"Error while starting {sc.DisplayName}", ex, updateStatus);
                return false;
            }
        }

        private static bool TryStopService(ServiceController sc, Action<string> updateStatus)
        {
            try
            {
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
                sc.Refresh();

                if (sc.Status == ServiceControllerStatus.Stopped)
                {
                    Logger.LogAndUpdate($"{sc.DisplayName} stopped successfully.", updateStatus);
                    return true;
                }

                Logger.LogAndUpdate($"Failed to stop {sc.DisplayName} within the expected time.", updateStatus);
                return false;
            }
            catch (Exception ex)
            {
                Logger.LogException($"Error while stopping {sc.DisplayName}", ex, updateStatus);
                return false;
            }
        }
    }
}