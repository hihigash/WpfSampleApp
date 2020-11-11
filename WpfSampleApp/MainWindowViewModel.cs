namespace WpfSampleApp
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                this.OnPropertyChanged();
            }
        }

        public GreetingCommand Greeting => new GreetingCommand(this);
    }
}