using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinForms3Feature.ViewModels;

namespace XamarinForms3Feature.Views
{
    public partial class FlexLayoutPage2 : ContentPage
    {
        public List<FlexItem2ViewModel> listOfImage;

        public FlexLayoutPage2()
        {
            InitializeComponent();

            listOfImage = new List<FlexItem2ViewModel>();

            MakeListofImage();

            LoadImagesInFlexLayout();
        }

        private void MakeListofImage()
        {
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img1.jpg"), Title="Mockup 1" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img2.jpeg"), Title = "Mockup 2" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img3.jpg"), Title = "Mockup 3" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img4.jpg"), Title = "Mockup 4" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img5.jpeg"), Title = "Mockup 5" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img6.jpg"), Title = "Mockup 6" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img7.jpg"), Title = "Mockup 7" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img8.jpeg"), Title = "Mockup 8" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img9.jpeg"), Title = "Mockup 9" });

            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img1.jpg"), Title = "Mockup 10" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img2.jpeg"), Title = "Mockup 11" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img3.jpg"), Title = "Mockup 12" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img4.jpg"), Title = "Mockup 13" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img5.jpeg"), Title = "Mockup 14" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img6.jpg"), Title = "Mockup 15" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img7.jpg"), Title = "Mockup 16" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img8.jpeg"), Title = "Mockup 17" });
            //listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img9.jpeg"), Title = "Mockup 18" });

            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/257840/pexels-photo-257840.jpeg?cs=srgb&dl=agriculture-apple-blur-257840.jpg&fm=jpg")), Title = "Mockup 1" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/853199/pexels-photo-853199.jpeg?cs=srgb&dl=4k-wallpaper-background-beautiful-853199.jpg&fm=jpg")), Title = "Mockup 2" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/443446/pexels-photo-443446.jpeg?cs=srgb&dl=daylight-forest-glossy-443446.jpg&fm=jpg")) , Title = "Mockup 3" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?cs=srgb&dl=beauty-bloom-blue-67636.jpg&fm=jpg")), Title = "Mockup 4" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg?cs=srgb&dl=4k-wallpaper-audi-audi-r8-1402787.jpg&fm=jpg")), Title = "Mockup 5" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/556416/pexels-photo-556416.jpeg?cs=srgb&dl=bridge-clouds-cloudy-556416.jpg&fm=jpg")), Title = "Mockup 6" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/33109/fall-autumn-red-season.jpg?cs=srgb&dl=autumn-colorful-colourful-33109.jpg&fm=jpg")), Title = "Mockup 7" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/753626/pexels-photo-753626.jpeg?cs=srgb&dl=beach-bora-bora-clouds-753626.jpg&fm=jpg")), Title = "Mockup 8" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/68147/waterfall-thac-dray-nur-buon-me-thuot-daklak-68147.jpeg?cs=srgb&dl=hd-wallpaper-landscape-long-exposure-68147.jpg&fm=jpg")), Title = "Mockup 9" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/462118/pexels-photo-462118.jpeg?cs=srgb&dl=bloom-blooming-blossom-462118.jpg&fm=jpg")), Title = "Mockup 10" });

            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img1.jpg"), Title = "Mockup 11" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img3.jpg"), Title = "Mockup 12" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img4.jpg"), Title = "Mockup 13" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img5.jpeg"), Title = "Mockup 14" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img6.jpg"), Title = "Mockup 15" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img7.jpg"), Title = "Mockup 16" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img8.jpeg"), Title = "Mockup 17" });
            listOfImage.Add(new FlexItem2ViewModel() { Image = ImageSource.FromFile("img9.jpeg"), Title = "Mockup 18" });

        }

        private void LoadImagesInFlexLayout()
        {
            if (listOfImage != null && listOfImage.Count > 0)
            {
                foreach (FlexItem2ViewModel flexItemViewModel in listOfImage)
                {
                    FlexItemView2 flexItemView = new FlexItemView2(flexItemViewModel);
                    flexItemView.WidthRequest = 350;

                    //Item clicked event
                    flexItemView.OnItemClicked+= FlexItemViewOnItemClicked;

                    // Add Image to FlexLayout
                    FlexLayout.Children.Add(flexItemView);
                }
            }
        }

        void FlexItemViewOnItemClicked(object sender, FlexItem2ViewModel FlexItem2ViewModel)
        {
            if(FlexItem2ViewModel!=null)
            {
                DisplayAlert("", "Purchased " + FlexItem2ViewModel.Title,"ok");
            }
        }

    }
}
