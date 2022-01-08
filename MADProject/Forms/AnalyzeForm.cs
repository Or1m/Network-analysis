﻿using MADProject.Enums;
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
            Utils.OnChangePath(NetPathTextBox, "network", "csv", EFileType.csv);
        }

        private void AnalysisPathButt_Click(object sender, System.EventArgs e)
        {
            Utils.OnChangePath(AnalysisPathTextBox, "analysis", "txt", EFileType.textfile);
        }

        private void AnalyzeButt_Click(object sender, System.EventArgs e)
        {
            string source = NetPathTextBox.Text;
            if (!File.Exists(source))
            {
                MessageBox.Show("File not exists", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EDegreeDistributionType type = EDegreeDistributionType.percentage;

            if (NodesRadioButt.Checked)
                type = EDegreeDistributionType.nodes;
            else if (BothRadioButt.Checked)
                type = EDegreeDistributionType.both;

            NetworkAnalyzer analyzer = NetworkAnalyzer.Instance;
            analyzer.Analyze(source);
            analyzer.PrintToConsole(type);
        }
    }
}
