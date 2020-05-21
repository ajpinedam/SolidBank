using System;
using SolidBank.Services;
using Splat;

namespace SolidBank
{
    public class AppBoostrapper : IEnableLogger
    {
        private static readonly AppBoostrapper _current = new AppBoostrapper();

        static AppBoostrapper() { }

        private AppBoostrapper() { }

        public static AppBoostrapper Current => _current;

        public void Run()
        {
            RegisterServices();
            RegisterViewModels();
        }

        private void RegisterViewModels()
        {
            var locator = Locator.CurrentMutable;

            locator.Register(() => new LoginViewModel(Locator.Current.GetService<IDialogService>()));
            locator.Register(() => new MainViewModel(Locator.Current.GetService<IUserService>()));
        }

        private void RegisterServices()
        {
            var locator = Locator.CurrentMutable;
            locator.RegisterConstant<IDialogService>(new SolidDialogService());
            locator.RegisterConstant<IUserService>(new UserService());
        }
    }
}
