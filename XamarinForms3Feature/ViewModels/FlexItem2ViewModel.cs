using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms3Feature.Views;

namespace XamarinForms3Feature.ViewModels
{
    public class FlexItem2ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public FlexItemView2 FlexItemView2;

        private ImageSource _bannerImage;
        private bool _isShowGif = true;
        private string _title = "";
        private string _description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.";
        public ICommand BannerImageCommand { get; private set; }
        public ICommand BuyCommand { get; private set; }


        public FlexItem2ViewModel()
        {
            BannerImageCommand = new Command(OnBannerImageClick);
            BuyCommand = new Command(OnBuyClick);
        }

        private void OnBannerImageClick()
        {
            // Banner Image Click
            if(FlexItemView2!=null)
            {

            }
        }

        private void OnBuyClick()
        {
            // Buy Button Click
            if (FlexItemView2 != null)
            {
                FlexItemView2.OnClickedBuy(this);
            }
        }


        public ImageSource Image
        {
            get
            {
                return _bannerImage;
            }
            set
            {
                _bannerImage = value;

                OnPropertyChanged();
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;

                OnPropertyChanged();
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;

                OnPropertyChanged();
            }
        }

        public bool IsShowGif
        {
            get
            {
                return _isShowGif;
            }
            set
            {
                _isShowGif = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
