using System;
using System.Collections.Generic;
using System.Threading;
using FFImageLoading.Forms;
using Xamarin.Forms;
using XamarinForms3Feature.ViewModels;

namespace XamarinForms3Feature.Views
{
    public partial class FlexItemView2 : ContentView
    {
        public event EventHandler<FlexItem2ViewModel> OnItemClicked;

        public CachedImage ImageBanner { get; set; }

        public FlexItem2ViewModel FlexItem2ViewModel;

        public FlexItemView2(FlexItem2ViewModel FlexItem2ViewModel)
        {
            InitializeComponent();

            ImageBanner = Image;

            this.FlexItem2ViewModel = FlexItem2ViewModel;
            this.FlexItem2ViewModel.FlexItemView2 = this;

            BindingContext = FlexItem2ViewModel;
        }
        


        void Handle_Success(object sender, FFImageLoading.Forms.CachedImageEvents.SuccessEventArgs e)
        {
            //Device.BeginInvokeOnMainThread(() =>
            //{

            //Thread.Sleep(4000);

            try
            {
                CachedImage cachedImage = (sender as CachedImage);

                FlexItem2ViewModel image = cachedImage.BindingContext as FlexItem2ViewModel;

                if (Device.RuntimePlatform == Device.Android)
                {
                    if (image != null)
                    {
                        image.IsShowGif = false;
                    }
                }
                else
                {
                    if (e.ImageInformation.CacheKey != null)
                    {
                        if (image != null)
                        {
                            image.IsShowGif = false;
                        }
                    }
                    else if (e.ImageInformation.Path != null)
                    {
                        if (image != null)
                        {
                            image.IsShowGif = false;
                        }
                    }
                }
            }
            catch (InvalidOperationException exe)
            { }
            // });
        }

        public void OnClickedBuy(FlexItem2ViewModel FlexItem2ViewModel)
        {
            if(OnItemClicked!=null)
            {
                OnItemClicked.Invoke(this, FlexItem2ViewModel);
            }
        }

    }
}
