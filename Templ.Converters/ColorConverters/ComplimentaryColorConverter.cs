using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Templ.Converters.Abstractions;
using Xamarin.Forms;

namespace Templ.Converters.ColorConverters
{
    public class ComplimentaryColorConverter:BaseColorConverter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!ValidateInput(value))
            {
                return Color.Default;
            }

            return Color.FromRgba(1 - ColorValue.R, 1 - ColorValue.G, 1 - ColorValue.B, ColorValue.A);
        }
    }
}
