using System;
using System.Collections.Generic;
using System.Text;

namespace MP4ToMP3Converter.ViewModel
{
    internal class DelegateCommand
    {
        private Action _execute;
        private Func<bool> _canExecute;
        public event EventHandler? CanExecuteChanged;
        public DelegateCommand(Action execute) { _execute = execute; }
        public DelegateCommand(Action execute, Func<bool> canexecute) { _execute = execute; _canExecute = canexecute; }
        public void OnExecuteChanged() => CanExecuteChanged?.Invoke(this, new EventArgs());
        public bool CanExecute(object? parameter) => _canExecute != null ? _canExecute() : true;
        public void Execute(object? parameter) => _execute();
    }
}
