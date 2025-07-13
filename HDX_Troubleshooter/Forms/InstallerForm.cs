// Future iterations can implement automated database/DICOM configuration at the end of the installation (if possible)
// ---> to avoid calls for software installed but database or DICOM path not configured

// TODO: Implement automated SubmitTicketForm if installation fails
// Remember to handle non-critical exceptions accordingly (e.g., already installed, newer version installed, etc.)

using HDX_ServiceTools.Core;
using HDX_ServiceTools.Helpers;
using HDX_ServiceTools.InstallHandlers;
using HDX_ServiceTools.Models;
using HDX_ServiceTools.Properties;

namespace HDX_ServiceTools.Forms
{
    public partial class InstallerForm : Form
    {
        private List<InstallationInfo> _installOptions = [];
        private InstallationInfo? _selectedOption = null;
        private CancellationTokenSource? _cancellationTokenSource;
        private string _selectedInstall = string.Empty;
        private int _lastSelectedIndex = -1;
        private bool _installationInProgress = false;
        private bool _isCancelling = false;
        private bool _success;

        // TODO: Implement remaining installation options and handlers
        // ---> NOTE: string key must match JSON's "Option" field
        private static readonly Dictionary<string, IInstallHandler> installHandlers = new()
        {
            ["Will-Master & OnDemand3D"] = new WMODHandler()
        };

        public InstallerForm()
        {
            InitializeComponent();
            Logo.Image = Resources.Logo;
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            AutoScaleMode = AutoScaleMode.Dpi;

            try
            {
                _installOptions = InterfaceUtils.LoadFromJSON<InstallationInfo>(Resources.installOptions);

                foreach (InstallationInfo option in _installOptions)
                {
                    lstOptions.Items.Add(option.Option);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The application encountered a critical error while loading installation options:\n\n{ex.Message}",
                    "Fatal Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Logger.Write($"The application encountered a critical error while loading installation options: {ex.Message}");
                Close();
            }
        }

        // This event fires whenever the selected index in the ListBox changes
        private void LstOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check two things:
            // 1. A valid selection exists (SelectedIndex != -1)
            // 2. The selection is actually different from the last one stored
            if (lstOptions.SelectedIndex != -1 && lstOptions.SelectedIndex != _lastSelectedIndex)
            {
                // Update the cached value so we know what the "last selected" index is
                _lastSelectedIndex = lstOptions.SelectedIndex;
                rtbDescription.Clear();

                if (lstOptions.SelectedItem != null)
                {
                    _selectedInstall = lstOptions.SelectedItem.ToString()!;

                    _selectedOption = InterfaceUtils.FindByOption(_installOptions, _selectedInstall);

                    if (_selectedOption != null)
                    {
                        rtbDescription.AppendText("The application will install the following:\r\n\r\n");
                        rtbDescription.SelectionBullet = true;

                        foreach (string text in _selectedOption.Description)
                            rtbDescription.AppendText($"{text}" + Environment.NewLine);

                        rtbDescription.SelectionBullet = false;
                        rtbDescription.AppendText("\r\nPlease ensure the computer has internet connection before continuing.");
                    }
                }
            }
        }

        private async void BtnContinue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedInstall) &&
                installHandlers.TryGetValue(_selectedInstall, out var handler))
            {
                UpdateUI();

                Logger.Write($"User selected installation option: {_selectedInstall}");

                _installationInProgress = true;
                _cancellationTokenSource = new CancellationTokenSource();

                Progress<int> progress = new(value =>
                {
                    prgInstall.Value = value;
                });

                try
                {
                    _success = await handler.HandleAsync(
                        message => txtStatus.AppendText($"{DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}"),
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

                if (_success)
                {
                    // TODO: Any post install instructions?
                    btnFinish.Visible = true;
                    btnHelp.Visible = true;
                }
                // else display contact support message box and redirect to SubmitTicketForm (similar to TroubleshooterForm)
                // ---> won't fail in DEMO mode (unless cancelled)
            }
            else if (string.IsNullOrEmpty(_selectedInstall))
            {
                MessageBox.Show(
                    "Please select an option to continue.",
                    "TBD",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Please use Will-Master + OnDemand3D option for proof of concept.",
                    "TBD",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void UpdateUI()
        {
            btnContinue.Visible = false;
            rtbDescription.Visible = false;
            lstOptions.Visible = false;
            lblOptions.Visible = false;
            btnHome.Visible = false;

            txtStatus.Visible = true;
            prgInstall.Visible = true;
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            FormManager.ReturnToEntryForm(this);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormManager.ReturnToEntryForm(this);
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            FormManager.ShowSubmitTicketForm();
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
    }
}