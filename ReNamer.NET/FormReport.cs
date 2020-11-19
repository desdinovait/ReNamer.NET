using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Files_Renamer.NET
{
    public partial class FormReport : Form
    {
        string destinationDir = string.Empty;

        public FormReport(int totalFiles, int copiedFiles, int movedFiles, int overwritedFiles, int resizedFiles, string destDir)
        {
            InitializeComponent();
            labelTotal.Text = totalFiles.ToString();
            labelCopied.Text = copiedFiles.ToString();
            labelMoved.Text = movedFiles.ToString();
            labelResized.Text = resizedFiles.ToString();
            labelOverwrited.Text = overwritedFiles.ToString();
            labelDir.Text = destDir;
            destinationDir = destDir;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDir_Click(object sender, EventArgs e)
        {
            Process.Start(destinationDir);
        }
    }
}