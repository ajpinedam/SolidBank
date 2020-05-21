using System;
using Acr.UserDialogs;

namespace SolidBank.Services
{
    public interface IDialogService
    {
        void ShowLoading();

        void HideLoading();
    }

    public class DialogService : IDialogService
    {
        public void HideLoading()
        {            
            UserDialogs.Instance.HideLoading();
        }

        public void ShowLoading()
        {
            UserDialogs.Instance.ShowLoading();
        }
    }
}
