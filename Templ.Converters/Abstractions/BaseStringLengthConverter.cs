using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Templ.Converters.Abstractions
{
    public abstract class BaseStringLengthConverter : IValueConverter
    {
        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        #region Methods

        protected bool CheckForNullValues(object value, object parameter)
        {
            if (string.IsNullOrEmpty((string)value) || parameter == null)
            {
                return false;
            }

            return true;
        }

        #endregion
    }
}
