// TODO: Implement cancellation handler mid-way through troubleshooting and make handler async?

using HDX_ServiceTools.Models;
using HDX_ServiceTools.TroubleshootHandlers;
using HDX_ServiceTools.Helpers;
using HDX_ServiceTools.Core;

namespace HDX_ServiceTools.Forms
{
    public partial class TroubleshooterForm : Form
    {
        private List<ErrorInfo> _knownErrors = [];
        private ErrorInfo? _selectedInfo = null;
        private string _selectedError = string.Empty;
        private string _selectedCode = string.Empty;

        // TODO: Update JSON & implement additional error handlers accordingly
        private static readonly Dictionary<string, IErrorHandler> errorHandlers = new()
        {
            ["H0080"] = new H0080Handler()
        };

        public TroubleshooterForm()
        {
            InitializeComponent();
            Logo.Image = Properties.Resources.Logo;
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            AutoScaleMode = AutoScaleMode.Dpi;

            try
            {
                _knownErrors = InterfaceUtils.LoadFromJSON();
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
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            // Create list of ErrorInfo objects, based on user's input
            List<ErrorInfo> matches = InterfaceUtils.Filter(_knownErrors, searchText.Text);

            // Clear the ListBox before updating it with new filtered results
            errorList.Items.Clear();

            // Add matches to the ListBox, or show fallback message if none found
            if (matches.Count > 0)
            {
                foreach (ErrorInfo error in matches)
                    errorList.Items.Add($"{error.Code}: {error.Message}");
            }
            else
                errorList.Items.Add("No matching issues found.");
        }

        private void ErrorList_DoubleClick(object sender, EventArgs e)
        {
            if (errorList.SelectedItem != null && (string)errorList.SelectedItem != "No matching issues found.")
            {
                Stage2();

                _selectedError = errorList.SelectedItem.ToString()!;
                Logger.Write($"User selected {_selectedError}");

                errorLabel.Text = $"\"{_selectedError}\" can be addressed by:";

                _selectedCode = InterfaceUtils.ExtractErrorCode(_selectedError);
                _selectedInfo = InterfaceUtils.FindByCode(_knownErrors, _selectedCode);

                if (_selectedInfo != null)
                {
                    foreach (string solution in _selectedInfo.Solutions)
                        statusText.AppendText($"~ {solution}" + Environment.NewLine);
                    statusText.AppendText(Environment.NewLine);
                }
            }
        }

        // TODO: Make methods asynchronous to avoid blocking the UI thread or allow user to cancel long-running operations?
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedInfo?.Code) &&
                errorHandlers.TryGetValue(_selectedInfo.Code, out var handler))
            {
                // Pass lambda to the handler that updates the statusText TextBox
                handler.Handle(message =>
                {
                    statusText.AppendText($"{DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}");
                });
            }
            else
                MessageBox.Show("No defined action for this error code.");
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            FormManager.ReturnToEntryForm(this);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Stage1();
        }

        private void Stage1()
        {
            enterLabel.Visible = true;
            searchText.Visible = true;
            errorList.Visible = true;

            errorLabel.Visible = false;
            statusText.Visible = false;
            backButton.Visible = false;
            continueButton.Visible = false;

            statusText.Clear();
        }

        private void Stage2()
        {
            enterLabel.Visible = false;
            searchText.Visible = false;
            errorList.Visible = false;

            errorLabel.Visible = true;
            statusText.Visible = true;
            backButton.Visible = true;
            continueButton.Visible = true;
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            FormManager.ShowSubmitTicketForm();
        }
    }
}