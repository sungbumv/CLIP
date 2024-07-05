using KitchenDisplay.ViewModels.Command;
using KitchenDisplay.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KitchenDisplay.ViewModels
{
    public class LoginViewModel : CommonViewModel
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
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        public string StatusMsg
        {
            get => statusMsg;
            set
            {
                statusMsg = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login, CanLogin);
        }

        private void Login(object parameter)
        {
            if (AuthenticateUser(userid, Password))
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
            return !string.IsNullOrEmpty(UserId) && !string.IsNullOrEmpty(Password);
        }

        private bool AuthenticateUser(string userid, string password)
        {
            return userid == "admin" && password == "password";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
