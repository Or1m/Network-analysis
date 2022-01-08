using System.IO;
using System.Windows.Forms;

namespace MADProject
{
    static class Utils
    {
        private const string textFileFormat = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        private const string csvFileFormat  = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
        public enum FileType
        {
            textfile,
            csv
        }

        public static void OnChangePath(TextBox target, string name, string extension, FileType fileType)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                RestoreDirectory = true,
                FileName = name,
                DefaultExt = extension,
                AddExtension = true,
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = fileType == FileType.csv ? csvFileFormat : textFileFormat,
                FilterIndex = 2
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                target.Text = dialog.FileName;
            }
        }
    }
}
