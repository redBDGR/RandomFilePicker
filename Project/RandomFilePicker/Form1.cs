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

namespace RandomFilePicker
{
    public partial class Form1 : Form
    {
        private FileInfo currentFile = null;

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
            currentFile = FileGrabber.SelectNewFile(dirTextBox.Text, ref fileNumText);
            if (currentFile == null)
            {
                return;
            }
            fileNameText.Text = currentFile.Name;
            filePositionText.Text = fileNumText;

            openFileButton.Enabled = true;
            deleteFileButton.Enabled = true;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (currentFile == null)
            {
                MessageBox.Show("No file was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            System.Diagnostics.Process.Start(currentFile.FullName);
        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            if (currentFile == null)
            {
                MessageBox.Show("No file was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            currentFile.Delete();
            currentFile = null;
            openFileButton.Enabled = false;
            deleteFileButton.Enabled = false;
            fileNameText.Text = "";
            filePositionText.Text = "";
        }
    }
}
