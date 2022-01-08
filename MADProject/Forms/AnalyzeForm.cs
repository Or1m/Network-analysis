using System.Windows.Forms;

namespace MADProject
{
    public partial class AnalyzeForm : Form
    {
        private readonly MainForm mainForm;

        public AnalyzeForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void AnalyzeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
