using MADProject.Enums;
using System;
using System.Windows.Forms;

namespace MADProject
{
    public partial class MainForm : Form
    {
        private NetworSampler sampler;

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
            Utils.OnChangePath(StatsPathTextBox, "stats", "txt", EFileType.Textfile);
        }
        private void SamplePathButt_Click(object sender, EventArgs e)
        {
            Utils.OnChangePath(SamplePathTextBox, "sample", "csv", EFileType.CSV);
        }

        private void SampleButt_Click(object sender, EventArgs e)
        {
            sampler = new NetworSampler();
            sampler.ParseData(NetPathTextBox.Text, DelimTextBox.Text.Trim()[0]);

            Enum.TryParse(MethodComboBox.SelectedValue.ToString(), out EMethodType method);
            sampler.DoSampling(method, int.Parse(SizeBox.Text), int.Parse(MaxIterBox.Text), 
                RNDBox.Checked? -1 : int.Parse(StartBox.Text));
        }

        private void PrintStatsButt_Click(object sender, EventArgs e)
        {
            if (FileRadioButt.Checked)
                Utils.RedirectConsoleToFile(StatsPathTextBox.Text, sampler.PrintStatsToConsole);
            else
                sampler.PrintStatsToConsole();
        }
        private void PrintSampleButt_Click(object sender, EventArgs e)
        {
            if (FileRadioButt.Checked)
                Utils.RedirectConsoleToFile(SamplePathTextBox.Text, sampler.PrintSampleToConsole);
            else
                sampler.PrintSampleToConsole();
        }

        private void RNDBox_CheckedChanged(object sender, EventArgs e)
        {
            StartBox.Enabled = !RNDBox.Checked;
        }
    }
}
