using MADProject.Enums;
using System.IO;
using System.Windows.Forms;

namespace MADProject
{
    static class Utils
    {
        private const string textFileFormat = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        private const string csvFileFormat  = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
       
        public static void OnChangePath(TextBox target, string name, string extension, EFileType fileType, bool saveFile = true)
        {
            FileDialog dialog = null;

            if (saveFile)
                dialog = new SaveFileDialog();
            else
                dialog = new OpenFileDialog();

            dialog.RestoreDirectory = true;
            dialog.FileName = name;
            dialog.DefaultExt = extension;
            dialog.AddExtension = true;
            dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.Filter = fileType == EFileType.csv ? csvFileFormat : textFileFormat;
            dialog.FilterIndex = 2;

            if (dialog.ShowDialog() == DialogResult.OK)
                target.Text = dialog.FileName;
        }
    }
}
