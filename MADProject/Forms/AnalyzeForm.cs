using System.IO;
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

        private void NetPathButt_Click(object sender, System.EventArgs e)
        {
            Utils.OnChangePath(NetPathTextBox, "network", "csv", Utils.FileType.csv);
        }

        private void AnalysisPathButt_Click(object sender, System.EventArgs e)
        {
            Utils.OnChangePath(AnalysisPathTextBox, "analysis", "txt", Utils.FileType.textfile);
        }

        private void AnalyzeButt_Click(object sender, System.EventArgs e)
        {
            string source = NetPathTextBox.Text;
            if (!File.Exists(source))
            {
                MessageBox.Show("File not exists", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NetworkAnalyzer analyzer = NetworkAnalyzer.Instance;
            analyzer.Analyze(source);
        }
    }
}
