namespace HDX_ServiceTools.Helpers
{
    public static class UserPrompts
    {
        public static bool PromptToRetryAppAndContinue(
            string contextMessage = "Please try opening the Will-Master application.\n\nIs the issue resolved?",
            string title = "Check Application",
            MessageBoxButtons buttons = MessageBoxButtons.YesNo,
            MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            return MessageBox.Show(contextMessage, title, buttons, icon) == DialogResult.Yes;
        }

        public static void PromptToContactSupport()
        {
            MessageBox.Show(
                "Please contact HDX support.",
                "Contact HDX support",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }

        public static void PromptWithInfo(string message)
        {
            MessageBox.Show(
                message,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
