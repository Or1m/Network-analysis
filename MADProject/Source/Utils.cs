using MADProject.Enums;
using System;
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
            FileDialog dialog;

            if (saveFile)
                dialog = new SaveFileDialog();
            else
                dialog = new OpenFileDialog();

            dialog.RestoreDirectory = true;
            dialog.FileName = name;
            dialog.DefaultExt = extension;
            dialog.AddExtension = true;
            dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.Filter = fileType == EFileType.CSV ? csvFileFormat : textFileFormat;
            dialog.FilterIndex = 2;

            if (dialog.ShowDialog() == DialogResult.OK)
                target.Text = dialog.FileName;
        }

        public static void RedirectConsoleToFile(string path, Action consoleOutput)
        {
            FileStream fileStream;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;

            if (File.Exists(path))
                File.Delete(path);

            try
            {
                fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(fileStream);
            }
            catch
            {
                MessageBox.Show("Cannot open file", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.SetOut(writer);
            consoleOutput?.Invoke();
            Console.SetOut(oldOut);

            writer.Close();
            fileStream.Close();
        }
    }
}
