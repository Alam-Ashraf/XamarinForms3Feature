using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms3Feature.Views;

namespace XamarinForms3Feature.ViewModels
{
    public class FlexItemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public FlexItemView FlexItemView { get; set; }
        private ImageSource _bannerImage;
        private bool _isShowGif = true;

        public ICommand BannerImageCommand { get; private set; }


        public FlexItemViewModel()
        {
            BannerImageCommand = new Command(OnBannerImageClick);
        }

        private void OnBannerImageClick()
        {
            // Banner Image Click
            if(FlexItemView!=null)
            {
                FlexItemView.ImageClickedPosition(this);
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
