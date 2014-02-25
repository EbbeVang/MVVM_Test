using System.ComponentModel;

namespace WpfApplication
{
    public class MainViewModel : INotifyPropertyChanged
    {

        public const string NamePropertyName = "CheckBoxState";

        private bool _checkboxstate = true;

        public bool CheckBoxState
        {
            get
            {
                return _checkboxstate;
            }
            set
            {
                if (_checkboxstate == value)
                {
                    return;
                }
                _checkboxstate = value;
                RaisePropertyChanged(NamePropertyName);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(
                    this,
                    new PropertyChangedEventArgs(propertyName));

            }
        }
    }
}