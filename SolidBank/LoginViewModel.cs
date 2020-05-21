using System;
using System.ComponentModel;
using System.Reactive;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ReactiveUI;
using SolidBank.Services;
using Acr.UserDialogs;

namespace SolidBank
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly AuthenticationService _authenticationService;
        private readonly IDialogService _dialogService;

        public event EventHandler SignInSuccesful;
        public event EventHandler SignInFailed;

        private string email;
        public string Email
        {
            get => email;
            set
            {
                email = value;
                RaisePropertyChanged(nameof(Email));
            }
        }

        private string password;
        public string Password
        {
            get => password;
            set
            {
                password = value;
                RaisePropertyChanged(nameof(Password));
            }
        }

        public ReactiveCommand<Unit, Unit> SignInCommand { get; set; }

        public LoginViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;

            SignInCommand = ReactiveCommand.CreateFromTask(SignInTask);

            _authenticationService = new AuthenticationService();
        }

        private async Task SignInTask()
        {
            try
            {
                _dialogService.ShowLoading();

                //TODO: Only for testing
                await Task.Delay(1000);

                var result = _authenticationService.SignIn(Email, Password);

                if (result)
                    SignInSuccesful?.Invoke(this, EventArgs.Empty);
                else
                    SignInFailed?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                SignInFailed?.Invoke(this, EventArgs.Empty);
            }
            finally
            {
                _dialogService.HideLoading();
            }
        }

        protected override void DoSomething(IAccountPayment selectedAccount)
        {
            
        }
    }
}
