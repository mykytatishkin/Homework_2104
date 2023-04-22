using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateFileFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindDuplicateFiles_Click(object sender, EventArgs e)
        {
            string sourcePath = txtSourcePath.Text;
            string targetPath = txtTargetPath.Text;
            Task.Run(() => FindAndCopyOriginalFiles(sourcePath, targetPath));
        }

        private void FindAndCopyOriginalFiles(string sourcePath, string targetPath)
        {
            DirectoryInfo sourceDirectory = new DirectoryInfo(sourcePath);
            DirectoryInfo targetDirectory = new DirectoryInfo(targetPath);
            if (!sourceDirectory.Exists)
            {
                MessageBox.Show("Source directory does not exist.");
                return;
            }
            if (!targetDirectory.Exists)
            {
                targetDirectory.Create();
            }
            foreach (FileInfo sourceFile in sourceDirectory.GetFiles())
            {
                if (IsOriginalFile(sourceFile, sourceDirectory.GetFiles()))
                {
                    string targetFilePath = Path.Combine(targetPath, sourceFile.Name);
                    File.Copy(sourceFile.FullName, targetFilePath);
                }
            }
        }

        private bool IsOriginalFile(FileInfo file, FileInfo[] files)
        {
            foreach (FileInfo f in files)
            {
                if (f.Name == file.Name && f.Length == file.Length && f.FullName != file.FullName)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
