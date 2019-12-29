using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinForms3Feature.Views.Common;

namespace XamarinForms3Feature.Network
{
    public class NetworkConnectivityHelper
    {
        private NoInternetConnectionView noInternetConnectionView;

        private Timer aTimer;
        private bool isShowing = false;

        public NetworkConnectivityHelper()
        {
            Connectivity.ConnectivityChanged += ConnectivityChanged;
        }

        private async void ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            var access = e.NetworkAccess;

            if (access == NetworkAccess.Internet)
            {
                //Local and internet access
                await ShowInternetConnectionPopup(true);
            }
            else if (access == NetworkAccess.None || access == NetworkAccess.Local)
            {
                //No connectivity is available
                await ShowInternetConnectionPopup(false);
            }
        }

        private async Task ShowInternetConnectionPopup(bool isInternetAvail)
        {
            Page currentPage = App.GetCurrentPage();

            if (currentPage != null)
            {
                if (!isShowing)
                {
                    isShowing = true;

                    await ShowNoInternetConnectionView(isInternetAvail);

                    StartTimer();
                }
                else
                {
                    aTimer.Close();

                    await PopupNavigation.Instance.PopAllAsync();

                    await ShowNoInternetConnectionView(isInternetAvail);

                    StartTimer();
                }
            }

        }

        private void StartTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new Timer(5000);

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            aTimer.Start();
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            HideNoInternetConnectionView();

            if (aTimer != null)
                aTimer.Stop();
        }

        private async Task ShowNoInternetConnectionView(bool isInternetAvail)
        {
            noInternetConnectionView = new NoInternetConnectionView(isInternetAvail);
            await PopupNavigation.Instance.PushAsync(noInternetConnectionView);
        }

        private void HideNoInternetConnectionView()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                try
                {
                    if (noInternetConnectionView != null && PopupNavigation.Instance.PopupStack.Count > 0 &&
                        PopupNavigation.Instance.PopupStack.Contains(noInternetConnectionView))
                    {
                        isShowing = false;

                        // Hide Internet Connection View
                        //PopupNavigation.Instance.RemovePageAsync(noInternetConnectionView);
                        PopupNavigation.Instance.PopAllAsync();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            });
        }

        ~NetworkConnectivityHelper()
        {
            Connectivity.ConnectivityChanged -= ConnectivityChanged;
        }

    }
}
