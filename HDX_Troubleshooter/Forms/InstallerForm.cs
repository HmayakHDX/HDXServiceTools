// TODO: Implement automated SubmitTicketForm if installation fails
// Remember to handle non-critical exceptions accordingly (e.g., already installed, newer version installed, etc.)

using HDX_ServiceTools.Core;
using HDX_ServiceTools.Helpers;
using HDX_ServiceTools.InstallHandlers;

namespace HDX_ServiceTools.Forms
{
    public partial class InstallerForm : Form
    {
        private string _selectedInstall = string.Empty;
        private CancellationTokenSource? _cancellationTokenSource;
        private bool _installationInProgress = false;
        private bool _isCancelling = false;

        // TODO: Implement remaining installation options and handlers
        private static readonly Dictionary<string, IInstallHandler> installHandlers = new()
        {
            ["WMOD"] = new WMODHandler()
        };

        public InstallerForm()
        {
            InitializeComponent();
            Logo.Image = Properties.Resources.Logo;
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void StandardInstallButton_Click(object sender, EventArgs e)
        {
            _selectedInstall = "WMOD";
            Logger.Write("User selected Will-Master + OnDemand3D installation option");

            Stage2();

            statusText.AppendText("~ Will-Master\r\n~ OnDemand3D\r\n~ Dependencies\r\n\r\n" +
                "* The application will first attempt to download the required files\r\n" +
                "* Please ensure the computer has internet connection\r\n\r\n"
            );
        }

        private async void ContinueButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedInstall) &&
                installHandlers.TryGetValue(_selectedInstall, out var handler))
            {
                Stage3();

                _installationInProgress = true;
                _cancellationTokenSource = new CancellationTokenSource();

                Progress<int> progress = new(value =>
                {
                    progressBar.Value = value;
                });

                try
                {
                    await handler.HandleAsync(
                        message => statusText.AppendText($"{DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}"),
                        progress,
                        _cancellationTokenSource.Token
                    );
                }

                // TODO: Catch any exceptions not controlled by user to allow for resets? (add button/reset GUI)
                catch (Exception ex)
                {
                    Logger.Write($"Handler successfully exited with {ex.Message}");
                }
                finally
                {
                    _installationInProgress = false;
                    _cancellationTokenSource?.Dispose();
                }

                // TODO: Finish button after successful install or any post install instructions?
                finishButton.Visible = true;
                btnHelp.Visible = true;
            }
        }

        // TODO: Implementation will be similar to StandardInstallButton_Click
        private void WmInstallButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Please use Will-Master + OnDemand3D option for proof of concept.",
                "TBD",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // TODO: Implementation will be similar to StandardInstallButton_Click
        private void OdInstallButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Please use Will-Master + OnDemand3D option for proof of concept.",
                "TBD",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // TODO: Implementation will be similar to StandardInstallButton_Click
        private void WillcephInstallButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Please use Will-Master + OnDemand3D option for proof of concept.",
                "TBD",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // TODO: Implementation will be similar to StandardInstallButton_Click
        private void BtnDentra_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Please use Will-Master + OnDemand3D option for proof of concept.",
                "TBD",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // TODO: Implementation will be similar to StandardInstallButton_Click
        private void BtnIray_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Please use Will-Master + OnDemand3D option for proof of concept.",
                "TBD",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            FormManager.ReturnToEntryForm(this);
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
            optionsLabel.Visible = true;
            standardInstallButton.Visible = true;
            wmInstallButton.Visible = true;
            odInstallButton.Visible = true;
            willcephInstallButton.Visible = true;
            btnIray.Visible = true;
            btnDentra.Visible = true;

            descriptionLabel.Visible = false;
            progressBar.Visible = false;
            statusText.Visible = false;
            backButton.Visible = false;
            continueButton.Visible = false;

            statusText.Clear();
        }

        private void Stage2()
        {
            optionsLabel.Visible = false;
            standardInstallButton.Visible = false;
            wmInstallButton.Visible = false;
            odInstallButton.Visible = false;
            willcephInstallButton.Visible = false;
            btnIray.Visible = false;
            btnDentra.Visible = false;

            descriptionLabel.Visible = true;
            progressBar.Visible = true;
            statusText.Visible = true;
            backButton.Visible = true;
            continueButton.Visible = true;
        }

        private void Stage3()
        {
            backButton.Visible = false;
            continueButton.Visible = false;
            homeButton.Visible = false;
            descriptionLabel.Visible = false;
            btnHelp.Visible = false;

            statusText.Clear();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_installationInProgress)
            {
                e.Cancel = true;

                if (_isCancelling) return;

                var result = MessageBox.Show(
                    "An installation is in progress.\n\nExiting now may leave the system in an incomplete state.\n\nAre you sure you want to cancel and exit?",
                    "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    Logger.Write("User cancelled installation");
                    _isCancelling = true;
                    BeginSafeExit();
                }
            }
            else
            {
                base.OnFormClosing(e);
            }
        }

        private async void BeginSafeExit()
        {
            if (_installationInProgress)
            {
                _cancellationTokenSource?.Cancel();

                while (_installationInProgress)
                {
                    await Task.Delay(100);
                }

                Logger.Write("Installation stopped. Closing Installer Form...");

                Invoke(() => Close());
                _isCancelling = false;
            }
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            FormManager.ShowSubmitTicketForm();
        }
    }
}