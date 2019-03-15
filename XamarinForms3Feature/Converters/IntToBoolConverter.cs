using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinForms3Feature.Converters
{
    public class IntToBoolConverter : IValueConverter
    {
        public IntToBoolConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int val = (int)value;

            if (val > 0)
            {
                return false;
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
