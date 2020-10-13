﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Templ.Converters.Abstractions;

namespace Templ.Converters
{
    class NumberGreaterThanOrEqualToZeroConverter : BaseNumberValueConverter
    {
        public new object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!ValidateInput(value))
            {
                return false;
            }

            if (FloatValue >= 0)
            {
                return true;
            }

            return false;
        }
    }
}