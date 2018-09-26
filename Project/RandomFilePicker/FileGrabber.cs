using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace RandomFilePicker
{
    public static class FileGrabber
    {
        public static FileInfo SelectNewFile(string currentDir, ref string filePositionText)
        {
            if (!Directory.Exists(currentDir))  // Checks the directory paramter to see if it exists
            {
                MessageBox.Show("You selected an invalid directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                return null;
            }
            DirectoryInfo dirInfo = new DirectoryInfo(currentDir);  // Create a new DirectoryInfo with the directory found in the params
            if (dirInfo == null)    // Checks if the DirectoryInfo was created properly
            {
                MessageBox.Show("You selected an invalid directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            List<FileInfo> files = dirInfo.GetFiles().ToList();
            if (files == null || files.Count == 0)  // Checks to see if the files list is valid
            {
                MessageBox.Show("No files were found in this directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            int numOfFiles = files.Count;

            Random rng = new Random();
            int randomFileIndex = rng.Next(0, numOfFiles);  // Gets a random number in the min & max
            FileInfo selectedFile = files[randomFileIndex];

            filePositionText = $"{randomFileIndex + 1} / {numOfFiles}";
            return selectedFile;
        }
    }
}
