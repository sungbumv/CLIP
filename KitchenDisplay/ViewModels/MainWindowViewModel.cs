using KitchenDisplay.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenDisplay.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {

        public BaseViewModel? _selectVm;
        /// <summary>
        /// Selected UserControl
        /// </summary>
        public BaseViewModel SelectedViewModel
        {
            get => _selectVm;
            set
            {
                _selectVm = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }


        public MainWindowViewModel()
        {
            SelectedViewModel = new LoginViewModel();
        }
    }
}
