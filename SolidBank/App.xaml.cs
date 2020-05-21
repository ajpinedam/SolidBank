using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolidBank
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            AppBoostrapper.Current.Run();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
