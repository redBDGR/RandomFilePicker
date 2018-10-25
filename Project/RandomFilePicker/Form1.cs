using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;

namespace RandomFilePicker
{
    public partial class Form1 : Form
    {
        private Stack<FileData> previousFileCache = new Stack<FileData>();
        private Stack<FileData> futureFileCache = new Stack<FileData>();
        private FileData currentFile = null;

        public class FileData
        {
            public FileData(FileInfo info, string pos)
            {
                file = info;
                fileLocation = pos;
            }

            public FileInfo file;
            public string fileLocation;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectDirButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.IsFolderPicker = true;
            dialog.EnsurePathExists = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                dirTextBox.Text = dialog.FileName;
                SetNewFile();
            }
        }

        private void selectNewButton_Click(object sender, EventArgs e)
        {
            SetNewFile();
        }

        private void SetNewFile()
        {
            string fileNumText = "";
            currentFile = new FileData(FileGrabber.SelectNewFile(dirTextBox.Text, ref fileNumText), fileNumText);
            previousFileCache.Push(currentFile);
            futureFileCache.Clear();
            if (currentFile == null)
            {
                return;
            }

            RefreshFile(currentFile);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (currentFile == null)
            {
                MessageBox.Show("No file was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                System.Diagnostics.Process.Start(currentFile.file.FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open selected file. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            if (currentFile == null)
            {
                MessageBox.Show("No file was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Are you sure you want to delete {currentFile.file.Name}", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            currentFile.file.Delete();
            currentFile = null;
            openFileButton.Enabled = false;
            deleteFileButton.Enabled = false;
            fileNameText.Text = "";
            filePositionText.Text = "";
        }

        private void previousFileButton_Click(object sender, EventArgs e)
        {
            if (previousFileCache.Count < 2)
                return;
            futureFileCache.Push(previousFileCache.Pop());
            RefreshFile(previousFileCache.Peek());
        }

        private void nextFileButton_Click(object sender, EventArgs e)
        {
            if (futureFileCache.Count < 1)
                return;
            previousFileCache.Push(futureFileCache.Pop());
            RefreshFile(previousFileCache.Peek());
        }

        public void RefreshFile(FileData fileData)
        {
            currentFile = fileData;
            if (previousFileCache.Count > 0)
                currentFile = previousFileCache.Peek();
            bool enabled = currentFile == null ? false : true;
            if (currentFile == null)
            {
                fileNameText.Text = "";
                filePositionText.Text = "";
            }
            else
            {
                fileNameText.Text = currentFile.file.Name;
                filePositionText.Text = currentFile.fileLocation;
            }

            nextFileButton.Enabled = futureFileCache.Count > 1;
            previousFileButton.Enabled = previousFileCache.Count > 1;

            openFileButton.Enabled = enabled;
            deleteFileButton.Enabled = enabled;
            moveFileButton.Enabled = enabled;
            nextFileButton.Enabled = enabled;
            previousFileButton.Enabled = enabled;
            selectNewButton.Enabled = !string.IsNullOrEmpty(dirTextBox.Text);
            openFileButton.Select();
        }

        private void moveFileButton_Click(object sender, EventArgs e)
        {
            if (currentFile == null)
            {
                MessageBox.Show("No file was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.IsFolderPicker = true;
            dialog.EnsurePathExists = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string targetDir = dialog.FileName;
                Debug.WriteLine(targetDir);
                Debug.WriteLine(currentFile.file.FullName);
                Debug.WriteLine($"{targetDir}//{currentFile.file.Name}");
                File.Move(currentFile.file.FullName, $"{targetDir}//{currentFile.file.Name}");

                previousFileCache.Pop();
                RefreshFile(null);
            }
        }
    }
}
