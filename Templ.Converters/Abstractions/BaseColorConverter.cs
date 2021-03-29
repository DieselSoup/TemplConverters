using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Templ.Converters.Abstractions
{
    public abstract class BaseColorConverter : IValueConverter
    {
        protected Color ColorValue;

        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return true;
        }

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        #region Methods

        protected bool ValidateInput(object value)
        {
            try
            {
                ColorValue = (Color)value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        #endregion 
    }
}
