using System.Windows;

namespace WpfSampleApp
{
    public class GreetingCommand : CommandBase
    {
        private readonly MainWindowViewModel _viewModel;

        public GreetingCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override bool CanExecuteCore(object parameter)
        {
            return true;
        }

        public override void ExecuteCore(object parameter)
        {
            MessageBox.Show($"Hello {_viewModel.Name}!");
        }
    }
}