using System;
using System.Collections.Generic;
using System.Threading;
using FFImageLoading.Forms;
using Xamarin.Forms;
using XamarinForms3Feature.Models;
using XamarinForms3Feature.ViewModels;

namespace XamarinForms3Feature.Views
{
    public partial class FlexItemView : ContentView
    {
        // Event Handler
        public event EventHandler<FlexItemViewModel> OnClickedImage;

        public CachedImage ImageBanner { get; set; }

        public FlexItemViewModel FlexItemViewModel;

        public FlexItemView(FlexItemViewModel FlexItemViewModel)
        {
            InitializeComponent();

            ImageBanner = Image;

            this.FlexItemViewModel = FlexItemViewModel;
            this.FlexItemViewModel.FlexItemView = this;

            BindingContext = FlexItemViewModel;
        }

        void Handle_Success(object sender, FFImageLoading.Forms.CachedImageEvents.SuccessEventArgs e)
        {
            //Device.BeginInvokeOnMainThread(() =>
            //{

            //Thread.Sleep(3000);

            try
            {
                CachedImage cachedImage = (sender as CachedImage);

                FlexItemViewModel image = cachedImage.BindingContext as FlexItemViewModel;

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

        public void ImageClickedPosition(FlexItemViewModel flexItemViewModel)
        {
            // Fire Event 
            if (OnClickedImage != null)
            {
                OnClickedImage.Invoke(this, flexItemViewModel);
            }
        }

    }
}
