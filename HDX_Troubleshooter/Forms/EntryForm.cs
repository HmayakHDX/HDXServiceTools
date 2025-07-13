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

        private void BtnInstall_Click(object sender, EventArgs e)
        {
            FormManager.ShowInstallerForm();
        }

        private void BtnTroubleshoot_Click(object sender, EventArgs e)
        {
            FormManager.ShowTroubleshooterForm();
        }

        // TODO: Requires involvement from Korean R&D for acquisition/automated measurements (if even possible)
        private void BtnQA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Need to consult with Korea if possible to implement.\n\n" +
                "Concept is to implement established QA/QC guide programatically and automate any parts possible.\n\n" +
                "For example: Guide user to set up phantom, acquisition, .raw loading in Will-DVTViewer, performing NYQ, CNR, HOM, MTF measurements (and Water/Air?)",
                "TBD",
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
