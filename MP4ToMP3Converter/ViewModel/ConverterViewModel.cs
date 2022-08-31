using MP4ToMP3Converter.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace MP4ToMP3Converter.ViewModel
{
    internal class ConverterViewModel : ViewModelBase
    {
        #region Fields
        private bool _inProgress = false;
        private string _sourcePath;
        private string _destinationPath;
        #endregion

        #region Properties
        public bool InProgress
        {
            get => _inProgress;
            set
            {
                if(_inProgress != value)
                {
                    _inProgress = value;
                    OnPropertyChanged(nameof(InProgress));
                }
            }
        }
        public string SourcePath
        {
            get => _sourcePath;
            set
            {
                if(value != _sourcePath)
                {
                    _sourcePath = value;
                    OnPropertyChanged(nameof(SourcePath));
                }
            }
        }
        public string DestinationPath
        {
            get => _destinationPath;
            set
            {
                if(value != _destinationPath)
                {
                    _destinationPath = value;
                    OnPropertyChanged(nameof(DestinationPath));
                }
            }
        }
        public DelegateCommand ConvertCommand { get; }
        public DelegateCommand SelectSourceCommand { get; }
        public DelegateCommand SelectDestinationCommand { get; set; }
        #endregion

        public ConverterViewModel()
        {
            SourcePath = "hallo welt";
            ConvertCommand = new DelegateCommand(Convert, CanConvert);
            SelectSourceCommand = new DelegateCommand(SelectSource, CanSelectSource);
            SelectDestinationCommand = new DelegateCommand(SelectDestination, CanSelectDestination);
        }

        #region Execute Methods
        private void Convert()
        {
            InProgress = true;
            for (int i = 0; i < 100000000; i++)
            {
                i += 1;
            }
            InProgress = false;
        }

        private void SelectSource()
        {
            MessageBox.Show("hi");
            OpenSelectDialog opendialog = new OpenSelectDialog();
            opendialog.OpenDialog();
        }

        private void SelectDestination()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region CanExecute Methods
        private bool CanConvert() => true; // !string.IsNullOrWhiteSpace(DestinationPath) && !string.IsNullOrWhiteSpace(SourcePath);
        private bool CanSelectSource() => true;
        private bool CanSelectDestination() => true;
        #endregion

    }
}
