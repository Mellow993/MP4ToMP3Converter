using System;
using System.Collections.Generic;
using System.Text;

namespace MP4ToMP3Converter.ViewModel
{
    internal class ConverterViewModel : ViewModelBase
    {
        public DelegateCommand ConvertCommand { get; }
        public ConverterViewModel()
        {
            ConvertCommand = new DelegateCommand(Convert, CanConvert);
        }

        private void Convert()
        {

        }

        private bool CanConvert()
        {
            return true;
        }

    }
}
