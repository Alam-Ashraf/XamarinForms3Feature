using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinForms3Feature.Converters
{
    public class BoolToReverseBoolConverter : IValueConverter
    {
        public BoolToReverseBoolConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !((bool)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !((bool)value);
        }
    }
}
