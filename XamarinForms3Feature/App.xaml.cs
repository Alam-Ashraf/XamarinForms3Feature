using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms3Feature.Network;
using XamarinForms3Feature.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinForms3Feature
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts

            // Register Network Connectivity Change Event
            NetworkConnectivityHelper networkConnectivityHelper = new NetworkConnectivityHelper();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


        public static Page GetCurrentPage()
        {
            if (Application.Current.MainPage != null &&
                Application.Current.MainPage.Navigation != null &&
                Application.Current.MainPage.Navigation.NavigationStack != null &&
                Application.Current.MainPage.Navigation.NavigationStack.Count > 0)
            {
                //LIFO is the only game in town! - so send back the last page
                Page currPage = App.Current.MainPage.Navigation.NavigationStack.LastOrDefault();

                return currPage;
            }

            return null;
        }
    }
}
