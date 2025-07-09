using HDX_ServiceTools.Forms;

namespace HDX_ServiceTools.Core
{
    /// <summary>
    /// FormManager is responsible for controlling navigation between forms in the application.
    /// It helps centralize logic for showing, hiding, or switching forms without repeating code.
    /// </summary>
    public static class FormManager
    {
        private static EntryForm? _entryForm;

        public static void RegisterEntryForm(EntryForm form)
        {
            _entryForm = form;
        }

        public static void ShowInstallerForm()
        {
            ShowFormAndReturnToEntry(new InstallerForm());
        }

        public static void ShowTroubleshooterForm()
        {
            ShowFormAndReturnToEntry(new TroubleshooterForm());
        }

        public static void ShowSubmitTicketForm()
        {
            SubmitTicketForm form = new();
            form.Show();
        }

        public static void ReturnToEntryForm(Form current)
        {
            _entryForm?.Show();
            current.Close();
        }

        private static void ShowFormAndReturnToEntry(Form form)
        {
            form.FormClosed += (sender, args) =>
            {
                _entryForm?.Show();
            };

            form.Show();
            _entryForm?.Hide();
        }
    }
}