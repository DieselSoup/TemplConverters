using System;
using System.Globalization;
using Xamarin.Forms;

namespace Templ.Converters
{
    public class StringIsNullOrEmptyToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!string.IsNullOrWhiteSpace((string)value))
            {
                return true;
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string ifNotNullOrEmpty = (string)parameter;

            if ((bool)value)
            {
                return ifNotNullOrEmpty;
            }

            return "";
        }
    }
}
