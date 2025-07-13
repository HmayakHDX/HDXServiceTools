// TODO: Implement cancellation handler mid-way through troubleshooting and make handler async?

using HDX_ServiceTools.Models;
using HDX_ServiceTools.TroubleshootHandlers;
using HDX_ServiceTools.Helpers;
using HDX_ServiceTools.Core;
using HDX_ServiceTools.Properties;

namespace HDX_ServiceTools.Forms
{
    public partial class TroubleshooterForm : Form
    {
        private List<ErrorInfo> _knownErrors = [];
        private ErrorInfo? _selectedInfo = null;
        private string _selectedError = string.Empty;
        private string _selectedCode = string.Empty;
        private bool _success;

        // TODO: Update JSON & implement additional error handlers accordingly
        private static readonly Dictionary<string, IErrorHandler> errorHandlers = new()
        {
            ["H0080"] = new H0080Handler()
        };

        public TroubleshooterForm()
        {
            InitializeComponent();
            Logo.Image = Resources.Logo;
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            AutoScaleMode = AutoScaleMode.Dpi;

            try
            {
                _knownErrors = InterfaceUtils.LoadFromJSON<ErrorInfo>(Resources.knownErrors);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The application encountered a critical error while loading known errors:\n\n{ex.Message}",
                    "Fatal Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Logger.Write($"The application encountered a critical error while loading known errors: {ex.Message}");
                Close();
            }
        }

        // Event handler that runs whenever the text in txtSearch changes
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            // Create list of ErrorInfo objects, based on user's input
            List<ErrorInfo> matches = InterfaceUtils.Filter(_knownErrors, txtSearch.Text);

            // Clear the ListBox before updating it with new filtered results
            lstError.Items.Clear();

            // Add matches to the ListBox, or show fallback message if none found
            if (matches.Count > 0)
            {
                foreach (ErrorInfo error in matches)
                    lstError.Items.Add($"{error.Code}: {error.Message}");
            }
            else
                lstError.Items.Add("No matching issues found.");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (lstError.SelectedItem != null && (string)lstError.SelectedItem != "No matching issues found.")
            {
                Stage2();

                _selectedError = lstError.SelectedItem.ToString()!;
                Logger.Write($"User selected {_selectedError}");

                lblDescription.Text = $"\"{_selectedError}\" can be addressed by:";

                _selectedCode = InterfaceUtils.ExtractErrorCode(_selectedError);
                _selectedInfo = InterfaceUtils.FindByCode(_knownErrors, _selectedCode);

                if (_selectedInfo != null)
                {
                    foreach (string solution in _selectedInfo.Solutions)
                        txtStatus.AppendText($"~ {solution}" + Environment.NewLine);
                    txtStatus.AppendText(Environment.NewLine);
                }
            }
        }

        // TODO: Make methods asynchronous to avoid blocking the UI thread or allow user to cancel long-running operations?
        private void BtnContinue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedInfo?.Code) &&
                errorHandlers.TryGetValue(_selectedInfo.Code, out var handler))
            {
                // Assign bool _success to handler's output
                // Pass lambda to the handler that updates the statusText TextBox
                _success = handler.Handle(message =>
                {
                    txtStatus.AppendText($"{DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}");
                });

                if (_success)
                {
                    UserPrompts.PromptWithInfo("Troubleshooting was successful");
                    Close();
                }
                else
                {
                    UserPrompts.PromptToContactSupport();
                    Close();
                    FormManager.ShowSubmitTicketForm();
                }
            }
            else
                MessageBox.Show("No defined action for this error code.");
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormManager.ReturnToEntryForm(this);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Stage1();
        }

        private void Stage1()
        {
            lblInstructions.Visible = true;
            txtSearch.Visible = true;
            lstError.Visible = true;
            btnNext.Visible = true;

            lblDescription.Visible = false;
            txtStatus.Visible = false;
            btnBack.Visible = false;
            btnContinue.Visible = false;

            txtStatus.Clear();
        }

        private void Stage2()
        {
            lblInstructions.Visible = false;
            txtSearch.Visible = false;
            lstError.Visible = false;
            btnNext.Visible = false;

            lblDescription.Visible = true;
            txtStatus.Visible = true;
            btnBack.Visible = true;
            btnContinue.Visible = true;
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            FormManager.ShowSubmitTicketForm();
        }
    }
}