using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinForms3Feature.ViewModels;

namespace XamarinForms3Feature.Views
{
    public partial class FlexLayoutPage : ContentPage
    {
        public List<FlexItemViewModel> listOfImage;

        public FlexLayoutPage()
        {
            InitializeComponent();

            listOfImage = new List<FlexItemViewModel>();

            MakeListofImage();

            LoadImagesInFlexLayout();
        }

        private void MakeListofImage()
        {
            // Image from Resource Folder
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img1.jpg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img2.jpeg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img3.jpg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img4.jpg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img5.jpeg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img6.jpg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img7.jpg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img8.jpeg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img9.jpeg"), });

            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img1.jpg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img2.jpeg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img3.jpg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img4.jpg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img5.jpeg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img6.jpg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img7.jpg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img8.jpeg"), });
            //listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img9.jpeg"), });

            // Image From URI
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/257840/pexels-photo-257840.jpeg?cs=srgb&dl=agriculture-apple-blur-257840.jpg&fm=jpg")) });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/853199/pexels-photo-853199.jpeg?cs=srgb&dl=4k-wallpaper-background-beautiful-853199.jpg&fm=jpg") )});
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/443446/pexels-photo-443446.jpeg?cs=srgb&dl=daylight-forest-glossy-443446.jpg&fm=jpg")) });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?cs=srgb&dl=beauty-bloom-blue-67636.jpg&fm=jpg")) });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg?cs=srgb&dl=4k-wallpaper-audi-audi-r8-1402787.jpg&fm=jpg")) });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/556416/pexels-photo-556416.jpeg?cs=srgb&dl=bridge-clouds-cloudy-556416.jpg&fm=jpg")) });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/33109/fall-autumn-red-season.jpg?cs=srgb&dl=autumn-colorful-colourful-33109.jpg&fm=jpg")) });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/753626/pexels-photo-753626.jpeg?cs=srgb&dl=beach-bora-bora-clouds-753626.jpg&fm=jpg")) });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/68147/waterfall-thac-dray-nur-buon-me-thuot-daklak-68147.jpeg?cs=srgb&dl=hd-wallpaper-landscape-long-exposure-68147.jpg&fm=jpg")) });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/462118/pexels-photo-462118.jpeg?cs=srgb&dl=bloom-blooming-blossom-462118.jpg&fm=jpg")) });

            // Image From Resources
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img1.jpg"), });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img2.jpeg"), });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img3.jpg"), });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img4.jpg"), });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img5.jpeg"), });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img6.jpg"), });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img7.jpg"), });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img8.jpeg"), });
            listOfImage.Add(new FlexItemViewModel() { Image = ImageSource.FromFile("img9.jpeg"), });
        }

        private void LoadImagesInFlexLayout()
        {
            if (listOfImage != null && listOfImage.Count > 0)
            {
                foreach (FlexItemViewModel flexItemViewModel in listOfImage)
                {
                    FlexItemView flexItemView = new FlexItemView(flexItemViewModel);
                    flexItemView.HeightRequest = 165;
                    flexItemView.WidthRequest = 175;

                    // Image clicked event
                    flexItemView.OnClickedImage+= FlexItemViewOnClickedImage;

                    // Add Image to FlexLayout
                    FlexLayout.Children.Add(flexItemView);
                }
            }
        }

        void FlexItemViewOnClickedImage(object sender, FlexItemViewModel flexItemViewModel)
        {
            // Image clieked position data
            if(flexItemViewModel!=null)
            {
                DisplayAlert("", ""+flexItemViewModel.Image, "ok");
            }
        }

    }
}
