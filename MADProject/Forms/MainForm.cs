using MADProject.Enums;
using System;
using System.Windows.Forms;

namespace MADProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MethodComboBox.DataSource = Enum.GetValues(typeof(EMethodType));
        }

        private void NetPathButt_Click(object sender, EventArgs e)
        {
            Utils.OnChangePath(NetPathTextBox, "network", "csv", EFileType.CSV, false);
        }
        private void StatsPathButt_Click(object sender, EventArgs e)
        {
            Utils.OnChangePath(AnalysisPathTextBox, "analysis", "txt", EFileType.Textfile);
        }
        private void SamplePathButt_Click(object sender, EventArgs e)
        {

        }

        private void SampleButt_Click(object sender, EventArgs e)
        {

        }

        private void PrintStatsButt_Click(object sender, EventArgs e)
        {

        }
        private void PrintSampleButt_Click(object sender, EventArgs e)
        {

        }

        private void RNDBox_CheckedChanged(object sender, EventArgs e)
        {
            StartBox.Enabled = !RNDBox.Checked;
        }

        private void Print(NetworSampler sampler)
        {
            if (FileRadioButt.Checked)
                sampler.PrintToFile(AnalysisPathTextBox.Text);
            else
                sampler.PrintToConsole();
        }
    }
}
