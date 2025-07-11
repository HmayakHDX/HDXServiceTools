using HDX_ServiceTools.Helpers;
using System.Text.RegularExpressions;

namespace HDX_ServiceTools.Forms
{
    public partial class SubmitTicketForm : Form
    {
        // TODO: Run TV in constructor? Can abstract to a helper method
        // -> Probably better to run it in the button click handlers instead (try/catch before calling Form constructor)
        public SubmitTicketForm()
        {
            InitializeComponent();
            Logo.Image = Properties.Resources.Logo;
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;

            string clinic = txtClinicName.Text.Trim();
            string dentist = txtDentistName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string issue = txtDescription.Text.Trim();
            string tvId = txtTVId.Text.Trim();
            string tvPassword = txtTVPassword.Text.Trim();
            string teamViewerInfo;

            if (!string.IsNullOrWhiteSpace(tvId) && !string.IsNullOrWhiteSpace(tvPassword))
            {
                teamViewerInfo = $"TeamViewer ID: {tvId}\nPassword: {tvPassword}";
            }
            else
            {
                teamViewerInfo = "[TeamViewer credentials not provided]";
            }

            string fullDescription =
                "=== TeamViewer Credentials ===\r\n" +
                teamViewerInfo + "\r\n" +
                "=== Issue Description ===\r\n" +
                issue;


            // Required field check
            // TODO: Is dentist name required?
            if (string.IsNullOrWhiteSpace(clinic) || string.IsNullOrWhiteSpace(dentist) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(issue))
            {
                UserPrompts.PromptWithInfo("Please fill out all required fields.");

                btnSubmit.Enabled = true;
                return;
            }

            // Email format validation
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                UserPrompts.PromptWithInfo("Please enter a valid email address.\n\n" +
                    "For example: dentist@gmail.com");

                btnSubmit.Enabled = true;
                return;
            }

            try
            {
                var (success, ticketId, message) = await FreshdeskClient.CreateTicketWithAttachmentAsync(
                    clinic, dentist, email, phone, fullDescription
                );

                UserPrompts.PromptWithInfo(message);

                Logger.Write(message);

                Close();
            }
            catch (Exception ex)
            {
                UserPrompts.PromptWithInfo($"Unexpected error: {ex.Message}");

                Logger.Write($"Error during ticket submission: {ex.Message}");

                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
