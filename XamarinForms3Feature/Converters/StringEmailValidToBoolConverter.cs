using System;
using System.Globalization;
using Xamarin.Forms;
using XamarinForms3Feature.Helpers;

namespace XamarinForms3Feature.Converters
{
    public class StringEmailValidToBoolConverter : IValueConverter
    {
        public StringEmailValidToBoolConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string val = (string)value;

            if (!string.IsNullOrEmpty(val))
            {
                if (Utils.IsValidEmail(val))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !((bool)value);
        }
    }
}