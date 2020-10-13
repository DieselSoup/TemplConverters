using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Templ.Converters.Abstractions
{
    public abstract class BaseNumberValueConverter : IValueConverter
    {
        protected float FloatValue { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        #region Methods

        protected bool ValidateInput(object value)
        {
            try
            {
                FloatValue = System.Convert.ToSingle(value);
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
