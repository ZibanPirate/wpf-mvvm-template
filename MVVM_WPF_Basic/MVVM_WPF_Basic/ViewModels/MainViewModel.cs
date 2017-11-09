using MVVM_WPF_Basic.Models;
using MVVM_WPF_Basic.ViewModels.Basis;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVM_WPF_Basic.ViewModels
{
    class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Accounts = new ObservableCollection<Account> { };
        }
        public ObservableCollection<Account> Accounts { get; set; }

        public ICommand AddItem => new DelegateCommand(_AddItem);
        void _AddItem()
        {
            Random rnd = new Random();
            string[] FirstNames = { "Zakaria", "Ghani", "Saleh", "Wassim", "Khalil" }
                , LastNames = { "Mansouri", "Nacer", "Hadef", "Djeffel", "Soltan" };
            Accounts.Add(new Account
            {
                Id = (uint)rnd.Next(),
                FirstName = FirstNames[rnd.Next(FirstNames.Length)],
                LastName = LastNames[rnd.Next(LastNames.Length)]
            });
        }
    }
}