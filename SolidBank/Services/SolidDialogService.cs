using System;
using MyDialogs = Acr.UserDialogs;

namespace SolidBank.Services
{
    public class SolidDialogService : IDialogService
    {
        public SolidDialogService()
        {
        }

        public void HideLoading()
        {
            MyDialogs.UserDialogs.Instance.HideLoading();
        }

        public void ShowLoading()
        {
            MyDialogs.UserDialogs.Instance.ShowLoading();
        }
    }
}
