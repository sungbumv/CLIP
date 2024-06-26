using KitchenDisplay.ViewModels.Command;
using KitchenDisplay.ViewModels.Common;
using System.Windows.Input;

namespace KitchenDisplay.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string userid;
        private string password;
        private string statusMsg;

        public string UserId
        {
            get => userid;
            set
            {
                userid = value;
                OnPropertyChanged("UserId");
            }
        }

        public string UserPassword
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged("UserPassword");
            }
        }

        public string StatusMsg
        {
            get => statusMsg;
            set
            {
                statusMsg = value;
                OnPropertyChanged("StatusMsg");
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login, CanLogin);
        }

        private void Login(object parameter)
        {
            if (AuthenticateUser(UserId, UserPassword))
            {
                statusMsg = "Login successful!";
            }
            else
            {
                statusMsg = "Invalid username or password.";
            }
        }

        private bool CanLogin(object parameter)
        {
            return !string.IsNullOrEmpty(UserId) && !string.IsNullOrEmpty(UserPassword);
        }

        private bool AuthenticateUser(string userid, string password)
        {
            return userid == "admin" && password == "password";
        }
    }
}
