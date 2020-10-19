using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Templ.Converters.Abstractions;

namespace Templ.Converters
{
    public class NumberEqualToZeroConverter: BaseNumberValueConverter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!ValidateInput(value))
            {
                return false;
            }

            if (FloatValue == 0)
            {
                return true;
            }

            return false;
        }
    }
}
