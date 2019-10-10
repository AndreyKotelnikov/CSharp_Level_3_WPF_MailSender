using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MailSender.Lib.MVVM
{
    public class LamdaCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        private readonly Action<object> _actionCommand;

        private readonly Func<object, bool> _canExecute;

        public LamdaCommand(Action<object> actionCommand, Func<object, bool> canExecute = null)
        {
            _actionCommand = actionCommand ?? throw new ArgumentNullException(nameof(actionCommand));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;

        public void Execute(object parameter) => _actionCommand(parameter);
    }
}
