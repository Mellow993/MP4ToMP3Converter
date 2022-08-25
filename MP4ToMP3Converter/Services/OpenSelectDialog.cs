using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MP4ToMP3Converter.Services
{
    internal class OpenSelectDialog
    {
        private string _filepath;
        public void OpenMYDialog()
        {
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.Filter = "mp4 files (*.mp4)|*.mp4";
                openFileDialog.Title = "Select your mp4 file";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                ShowDialog(openFileDialog);
            }
        }

        private void ShowDialog(System.Windows.Forms.OpenFileDialog openfiledialog)
        {
            if (openfiledialog.ShowDialog() == DialogResult.OK) ;
                _filepath = openfiledialog.FileName;
        }
    }
}
