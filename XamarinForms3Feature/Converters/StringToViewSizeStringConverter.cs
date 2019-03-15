using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinForms3Feature.Converters
{
    public class StringToViewSizeStringConverter : IValueConverter
    {
        public StringToViewSizeStringConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string val = (string)value;

            if (!string.IsNullOrEmpty(val))
            {
                return new FlexBasis(0.90f, true);
            }
            else
            {
                return new FlexBasis(1f, true);
            }


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !((bool)value);
        }
    }
}
