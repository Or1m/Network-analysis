using System;
using System.Windows.Forms;

namespace MADProject
{
    public partial class MainForm : Form
    {
        private GenerateForm generateForm;
        private AnalyzeForm analyzeForm;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateButt_Click(object sender, EventArgs e)
        {
            generateForm = new GenerateForm(this);
            generateForm.Show();
            Enabled = false;
        }
        private void AnalyzeButt_Click(object sender, EventArgs e)
        {
            analyzeForm = new AnalyzeForm(this);
            analyzeForm.Show();
            Enabled = false;
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }
    }
}
