using System.IO;
using System.Windows.Forms;

namespace MADProject
{
    public partial class GenerateForm : Form
    {
        private readonly MainForm mainForm;

        public GenerateForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void GenerateForm_Load(object sender, System.EventArgs e)
        {
            TypeComboBox.SelectedIndex = 2;
        }
        private void TypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (TypeComboBox.SelectedIndex != 2)
            {
                RunButt.Enabled = false;
                ErrorLabel.Visible = true;
            }
            else
            {
                RunButt.Enabled = true;
                ErrorLabel.Visible = false;
            }
        }
        private void GenerateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
        
        private void ChangePathButt_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                RestoreDirectory = true,
                FileName = "network",
                DefaultExt = "csv",
                AddExtension = true,
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*",
                FilterIndex = 2
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PathTextBox.Text = dialog.FileName;
            }
        }
        private void RunButt_Click(object sender, System.EventArgs e)
        {
            int numOfNodes = int.Parse(NumOfNodesTextBox.Text);
            int numOfNewEdgesPerNode = int.Parse(MTextBox.Text);

            NetworkGenerator generator = NetworkGenerator.Instance;
            generator.Generate(numOfNodes, numOfNewEdgesPerNode);
            
            //generator.PrintToConsole();
            generator.PrintToFile(PathTextBox.Text);

            Close();
        }
    }
}
