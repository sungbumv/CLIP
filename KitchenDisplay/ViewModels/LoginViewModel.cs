using KitchenDisplay.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
