using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Backuper4000
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sourcePathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sourceFolderDialog = new FolderBrowserDialog() { ShowNewFolderButton = true };
            sourceFolderDialog.ShowDialog();
            if (sourceFolderDialog.SelectedPath != "")
                sourcePathTextBox.Text = sourceFolderDialog.SelectedPath;
        }

        private void destinationPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog destinationFolderDialog = new FolderBrowserDialog() { ShowNewFolderButton = true };
            destinationFolderDialog.ShowDialog();
            if (destinationFolderDialog.SelectedPath != "")
                destinationPathTextBox.Text = destinationFolderDialog.SelectedPath;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            logTextBox.Enabled = true;
            logTextBox.Clear();
            BackupTools.StartBackup(sourcePathTextBox.Text, destinationPathTextBox.Text, Log);
        }

        public void Log(string message)
        {
            if (!message.EndsWith(Environment.NewLine))
                message += Environment.NewLine;
            logTextBox.AppendText(message);
        }

    }
}
