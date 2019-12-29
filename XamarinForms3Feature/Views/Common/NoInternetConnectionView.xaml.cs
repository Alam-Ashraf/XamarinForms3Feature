using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms3Feature.Views.Common
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoInternetConnectionView : PopupPage
    {
        public NoInternetConnectionView(bool isInternetAvail)
        {
            InitializeComponent();

            SetColorAndText(isInternetAvail);
        }

        private void SetColorAndText(bool isInternetAvail)
        {
            if (isInternetAvail)
            {
                // Connected
                FrameBackground.BackgroundColor = Color.FromHex("#32CD32");
                LabelTitle.Text = "Connected";
            }
            else
            {
                // Connection lost
                FrameBackground.BackgroundColor = Color.Red;
                LabelTitle.Text = "No internet connection";
            }
        }
    }
}