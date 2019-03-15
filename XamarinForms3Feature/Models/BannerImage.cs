using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace XamarinForms3Feature.Models
{
    public class BannerImage : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

       

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
