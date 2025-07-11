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
        private static SubmitTicketForm? _submitTicketForm;

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
            if (_submitTicketForm is { Visible: true })
            {
                // Already open — bring to front
                if (_submitTicketForm.WindowState == FormWindowState.Minimized)
                    _submitTicketForm.WindowState = FormWindowState.Normal;

                _submitTicketForm.BringToFront();
                _submitTicketForm.Activate();
                return;
            }

            // Either not created or was closed — create a new one
            _submitTicketForm = new SubmitTicketForm();

            // Clean up the reference when the form is closed so a new one can be created next time
            _submitTicketForm.FormClosed += (sender, e) => _submitTicketForm = null;

            _submitTicketForm.Show();
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