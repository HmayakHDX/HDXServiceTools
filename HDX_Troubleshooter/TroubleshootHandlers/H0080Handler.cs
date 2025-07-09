using HDX_ServiceTools.Helpers;
using HDX_ServiceTools.Core;

namespace HDX_ServiceTools.TroubleshootHandlers
{
    public class H0080Handler : IErrorHandler
    {
        public void Handle(Action<string> updateStatus)
        {
            Logger.LogAndUpdate("Starting troubleshooting for error H0080...", updateStatus);

            if (!ServiceUtils.TryVerifyDongle(updateStatus))
            {
                Logger.LogAndUpdate("Prompting user to reconnect the license key...", updateStatus);

                if (UserPrompts.PromptToRetryAppAndContinue(
                    "Please reconnect the license key and try to open the Will-Master application again.\n\nIs the issue resolved?",
                    "Reconnect USB",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information))
                {
                    Logger.LogAndUpdate("Reconnecting the license key resolved the issue.", updateStatus);
                    return;
                }
            }

            // START DEMO
            // Simulating service check and user response for demonstration purposes

            Logger.LogAndUpdate("Simulating service check & configuration...", updateStatus);

            Task.Delay(5000).Wait(); // Simulate a delay for service check

            if (UserPrompts.PromptToRetryAppAndContinue())
            {
                Logger.LogAndUpdate("Starting/Restarting the service resolved the issue.", updateStatus);
                return;
            }

            // END DEMO

            //Actual service checking and configuration logic below (commented out for demonstration purposes)
            /*if (ServiceUtils.TryVerifyService("hasplms", updateStatus))
            {
                Logger.LogAndUpdate("Prompting user to retry after service configuration...", updateStatus);

                if (UserPrompts.PromptToRetryAppAndContinue())
                {
                    Logger.LogAndUpdate("Starting/Restarting the service resolved the issue.", updateStatus);
                    return;
                }
            }*/

            Logger.LogAndUpdate("Please contact HDX support.", updateStatus);
            UserPrompts.PromptToContactSupport();
            FormManager.ShowSubmitTicketForm();
        }
    }
}