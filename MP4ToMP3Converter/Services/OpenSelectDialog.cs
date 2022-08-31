using System;
using System.Windows.Forms;

namespace MP4ToMP3Converter.Services
{
    internal class OpenSelectDialog
    {
        private string _filepath = string.Empty;
        private string _initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public string SelectDialog()
        {
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.Filter = "mp4 files (*.mp4)|*.mp4";
                openFileDialog.Title = "Select your mp4 file";
                openFileDialog.InitialDirectory = _initialDirectory;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    _filepath = openFileDialog.FileName;
            }
            if (string.IsNullOrEmpty(_filepath))
                return string.Empty;
            else
                return _filepath;
        }

        public void SaveDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = _initialDirectory;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                _filepath = saveFileDialog.FileName;
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
