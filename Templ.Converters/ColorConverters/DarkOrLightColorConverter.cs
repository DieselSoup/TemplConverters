using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Templ.Converters.Abstractions;
using Xamarin.Forms;

namespace Templ.Converters.ColorConverters
{
    public class DarkOrLightColorConverter: BaseColorConverter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!ValidateInput(value))
            {
                return Color.Default;
            }

            if (ColorValue.R * 0.299 + ColorValue.G * 0.587 + ColorValue.B * 0.114 > 0.86)
            {
                return Color.Black;
            }
            else
            {
                return Color.White;
            }        
        }
    }
}
