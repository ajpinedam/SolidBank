using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Splat;
using Xamarin.Forms;

namespace SolidBank
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainViewModel ViewModel { get; }

        public MainPage()
        {
            ViewModel = Locator.Current.GetService<MainViewModel>();
            InitializeComponent();
            BindingContext = ViewModel;
        }
    }
}
