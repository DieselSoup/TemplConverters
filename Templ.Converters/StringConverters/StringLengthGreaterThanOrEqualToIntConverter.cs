using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Templ.Converters.Abstractions;

namespace Templ.Converters
{
    public class StringLengthGreaterThanOrEqualToIntConverter : BaseStringLengthConverter
    {
        public new object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (CheckForNullValues(value, parameter))
            {
                return false;
            }

            if (((string)value).Length < (int)parameter)
            {
                return false;
            }

            return true;
        }
    }
}
