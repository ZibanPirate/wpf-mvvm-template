using MVVM_WPF_Basic.Models;
using MVVM_WPF_Basic.ViewModels.Basis;
using System.Collections.ObjectModel;

namespace MVVM_WPF_Basic.ViewModels
{
    class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Accounts = new ObservableCollection<Account> { };
        }
        public ObservableCollection<Account> Accounts { get; set; }
    }
}