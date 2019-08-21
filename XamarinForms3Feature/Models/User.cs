using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XamarinForms3Feature.Models
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ImageSource _userImage;
        private string _userName;

        public User()
        {
        }


        public ImageSource UserImage
        {
            get
            {
                return _userImage;
            }
            set
            {
                if (value != null)
                {
                    _userImage = value;
                }
                OnPropertyChanged();

            }

        }

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value != null)
                {
                    _userName = value;
                }
                OnPropertyChanged();
            }

        }


        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
