using HDX_ServiceTools.Core;

namespace HDX_ServiceTools.Forms
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
            Logo.Image = Properties.Resources.Logo;
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            FormManager.ShowInstallerForm();
        }

        private void TroubleshootButton_Click(object sender, EventArgs e)
        {
            FormManager.ShowTroubleshooterForm();
        }

        // TODO: Similar to workstation troubleshooting, but different set of errors (dictionary change)
        private void TroubleshootWorkstationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Please use Troubleshoot (Server) option for proof of concept.",
                "To Be Developed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // TODO: Requires involvement from Korean R&D for acquisition/automated measurements (if even possible)
        private void QualityAssuranceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Need to consult with Korea if possible to implement.\n\n" +
                "Concept is to implement established QA/QC guide programatically and automate any parts possible.\n\n" +
                "Guide user to set up phantom, acquisition, .raw loading in Will-DVTViewer, performing NYQ, CNR, HOM, MTF measurements (and Water/Air?)",
                "To Be Developed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            FormManager.ShowSubmitTicketForm();
        }
    }
}
