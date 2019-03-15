using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinForms3Feature.ViewModels;

namespace XamarinForms3Feature
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel MainPageViewModel;

        public MainPage()
        {
            InitializeComponent();

            MainPageViewModel = new MainPageViewModel();
            MainPageViewModel.Navigation = Navigation;

            BindingContext = MainPageViewModel;

        }
    }
}
