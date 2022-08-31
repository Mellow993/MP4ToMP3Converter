using MP4ToMP3Converter.Services;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
                if(_sourcePath != value)
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
        public DelegateCommand ConvertCommand { get; set; }
        public DelegateCommand SelectSourceCommand { get; set; }
        public DelegateCommand SelectDestinationCommand { get; set; }
        #endregion

        public ConverterViewModel()
        {
            ConvertCommand = new DelegateCommand(Convert, CanConvert);
            SelectSourceCommand = new DelegateCommand(SelectSource, CanSelectSource);
            SelectDestinationCommand = new DelegateCommand(SelectDestination, CanSelectDestination);
        }

        #region Execute Methods
        private void Convert()
        {
            InProgress = true;
            InProgress = false;
        }

        private void SelectSource()
        {
            OpenSelectDialog opendialog = new OpenSelectDialog();
            SourcePath = opendialog.OpenDialog();
        }

        private void SelectDestination()
        {
            OpenSelectDialog opendialog = new OpenSelectDialog();
            opendialog.OpenDialog();
        }
        #endregion

        #region CanExecute Methods
        private bool CanConvert() => !string.IsNullOrWhiteSpace(DestinationPath) && !string.IsNullOrWhiteSpace(SourcePath);
        private bool CanSelectSource() => true;
        private bool CanSelectDestination() => true;
        #endregion

        #region RaisePropertyChanged
        private void RaisePropertyChanged([CallerMemberName] string propname = "")
        {
            SelectSourceCommand.OnExecuteChanged();
        }
        #endregion

    }
}
