using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SolidBank.Services;

namespace SolidBank
{
    public class MainViewModel : BaseViewModel
    {
        private readonly TransactionsService transationsService = new TransactionsService();
        private readonly IUserService _userService;

        private string currentUser;
        public string CurrentUser
        {
            get => currentUser;
            set
            {
                currentUser = value;
                RaisePropertyChanged(nameof(CurrentUser));
            }
        }

        private ObservableCollection<BaseAccount> accounts;
        public ObservableCollection<BaseAccount> Accounts
        {
            get => accounts;
            set
            {
                accounts = value;
                RaisePropertyChanged(nameof(Accounts));
            }
        }

        public MainViewModel(IUserService userService)
        {
            _userService = userService;
            LoadAccountInfo();
            CurrentUser = userService.GetUserInformation(1)?.Name;
        }

        private void LoadAccountInfo()
        {
            var accounts = transationsService.GetAccounts();
            Accounts = new ObservableCollection<BaseAccount>(accounts);
        }

        protected override void DoSomething(IAccountPayment selectedAccount)
        {
            //asdsa
            selectedAccount.PayAmount(200);
            //sdaskdas
        }
    }
}
