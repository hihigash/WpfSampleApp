using System;
using System.Windows.Input;

namespace WpfSampleApp
{
    public abstract class CommandBase : ICommand
    {
        public abstract bool CanExecuteCore(object parameter);
        public abstract void ExecuteCore(object parameter);
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            try
            {
                return this.CanExecuteCore(parameter);
            }
            catch (Exception e)
            {
                // do something
                throw;
            }
        }

        public void Execute(object parameter)
        {
            try
            {
                this.ExecuteCore(parameter);
            }
            catch (Exception e)
            {
                // do something
                throw;
            }
        }
    }
}
