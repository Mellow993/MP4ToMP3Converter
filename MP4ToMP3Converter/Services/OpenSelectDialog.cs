using System;
using System.Windows.Forms;

namespace MP4ToMP3Converter.Services
{
    internal class OpenSelectDialog
    {
        private string _filepath = string.Empty;
        public string OpenDialog()
        {
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.Filter = "mp4 files (*.mp4)|*.mp4";
                openFileDialog.Title = "Select your mp4 file";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                    _filepath = openFileDialog.FileName;
            }
            if (string.IsNullOrEmpty(_filepath))
                return string.Empty;
            else
                return _filepath;
        }

        //private string ShowDialog(System.Windows.Forms.OpenFileDialog openfiledialog)
        //{
        //    if (openfiledialog.ShowDialog() == DialogResult.OK)
        //        _filepath = openfiledialog.FileName;
        //    else
        //        return _filepath = string.Empty;
        //}
    }
}
