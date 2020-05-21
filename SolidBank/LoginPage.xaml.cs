using System;
using System.Collections.Generic;
using Acr.UserDialogs;
using SolidBank.Services;
using Splat;
using Xamarin.Forms;

namespace SolidBank
{
    public partial class LoginPage : ContentPage
    {
        public LoginViewModel ViewModel { get; }

        public LoginPage()
        {
            ViewModel = Locator.Current.GetService<LoginViewModel>();
            InitializeComponent();
            BindingContext = ViewModel;

            ViewModel.SignInFailed += ViewModel_SignInFailed;
            ViewModel.SignInSuccesful += ViewModel_SignInSuccesful;
        }

        private void ViewModel_SignInSuccesful(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }

        private void ViewModel_SignInFailed(object sender, EventArgs e)
        {
            UserDialogs.Instance.Alert("Usuario y/o password son incorrectos", "");
        }
    }
}
