using System;
using System.Collections.Generic;
using System.Text;

namespace MP4ToMP3Converter.ViewModel
{
    internal class ConverterViewModel : ViewModelBase
    {

        private bool _inProgress;
        private string _sourcePath;
        private string _destinationPath;

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
        public DelegateCommand SelectDestinationCommand { get; }
        public ConverterViewModel()
        {
            ConvertCommand = new DelegateCommand(Convert, CanConvert);
            SelectSourceCommand = new DelegateCommand(SelectSource, CanSelectSource);
            SelectDestinationCommand = new DelegateCommand(SelectDestination, CanSelectDestination);
        }
        private void Convert()
        {
            InProgress = true;
            // implement something
            InProgress = false;
        }

        private bool CanConvert()
        {
            return true;
        }

        private void SelectSource()
        {
            throw new NotImplementedException();
        }
        private bool CanSelectSource()
        {
            return true;
        }


        private void SelectDestination()
        {

            throw new NotImplementedException();
        }

        private bool CanSelectDestination()
        {
            return true;
        }
    }
}
