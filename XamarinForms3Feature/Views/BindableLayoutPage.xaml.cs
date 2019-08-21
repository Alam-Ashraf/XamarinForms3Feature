using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms3Feature.Models;

namespace XamarinForms3Feature.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindableLayoutPage : ContentPage
    {
        ObservableCollection<User> UserList;

        public BindableLayoutPage()
        {
            InitializeComponent();

            MakeUserList();

            BindableLayout.SetItemsSource(FlexLayoutContainer, UserList);
        }

        private void MakeUserList()
        {
            UserList = new ObservableCollection<User>();

            UserList.Add(new User()
            {
                UserName = "Image 1",
                UserImage = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/257840/pexels-photo-257840.jpeg?cs=srgb&dl=agriculture-apple-blur-257840.jpg&fm=jpg"))
            });

            UserList.Add(new User()
            {
                UserName = "Image 2",
                UserImage = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/853199/pexels-photo-853199.jpeg?cs=srgb&dl=4k-wallpaper-background-beautiful-853199.jpg&fm=jpg"))
            });

            UserList.Add(new User()
            {
                UserName = "Image 3",
                UserImage = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/462118/pexels-photo-462118.jpeg?cs=srgb&dl=bloom-blooming-blossom-462118.jpg&fm=jpg"))
            });

            UserList.Add(new User()
            {
                UserName = "Image 4",
                UserImage = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/68147/waterfall-thac-dray-nur-buon-me-thuot-daklak-68147.jpeg?cs=srgb&dl=hd-wallpaper-landscape-long-exposure-68147.jpg&fm=jpg"))
            });

            UserList.Add(new User()
            {
                UserName = "Image 5",
                UserImage = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/753626/pexels-photo-753626.jpeg?cs=srgb&dl=beach-bora-bora-clouds-753626.jpg&fm=jpg"))
            });

            UserList.Add(new User()
            {
                UserName = "Image 6",
                UserImage = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/33109/fall-autumn-red-season.jpg?cs=srgb&dl=autumn-colorful-colourful-33109.jpg&fm=jpg"))
            });

            UserList.Add(new User()
            {
                UserName = "Image 7",
                UserImage = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/556416/pexels-photo-556416.jpeg?cs=srgb&dl=bridge-clouds-cloudy-556416.jpg&fm=jpg"))
            });

            UserList.Add(new User()
            {
                UserName = "Image 8",
                UserImage = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/1402787/pexels-photo-1402787.jpeg?cs=srgb&dl=4k-wallpaper-audi-audi-r8-1402787.jpg&fm=jpg"))
            });

            UserList.Add(new User()
            {
                UserName = "Image 9",
                UserImage = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/67636/rose-blue-flower-rose-blooms-67636.jpeg?cs=srgb&dl=beauty-bloom-blue-67636.jpg&fm=jpg"))
            });

            UserList.Add(new User()
            {
                UserName = "Image 10",
                UserImage = ImageSource.FromUri(new Uri("https://images.pexels.com/photos/443446/pexels-photo-443446.jpeg?cs=srgb&dl=daylight-forest-glossy-443446.jpg&fm=jpg"))
            });

            UserList.Add(new User()
            {
                UserName = "Image 11",
                UserImage = ImageSource.FromFile("img5.jpeg")
            });

            UserList.Add(new User()
            {
                UserName = "Image 12",
                UserImage = ImageSource.FromFile("img6.jpg")
            });

            UserList.Add(new User()
            {
                UserName = "Image 13",
                UserImage = ImageSource.FromFile("img7.jpg")
            });

            UserList.Add(new User()
            {
                UserName = "Image 14",
                UserImage = ImageSource.FromFile("img8.jpeg")
            });

            UserList.Add(new User()
            {
                UserName = "Image 15",
                UserImage = ImageSource.FromFile("img9.jpeg")
            });

            UserList.Add(new User()
            {
                UserName = "Image 16",
                UserImage = ImageSource.FromFile("img1.jpg")
            });

            UserList.Add(new User()
            {
                UserName = "Image 17",
                UserImage = ImageSource.FromFile("img3.jpg")
            });

            UserList.Add(new User()
            {
                UserName = "Image 18",
                UserImage = ImageSource.FromFile("img4.jpg")
            });

        }
    }
}
