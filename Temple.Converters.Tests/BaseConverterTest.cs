using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Temple.Converters.Tests
{
    public abstract class BaseConverterTest<T> where T:IValueConverter
    {
        protected T Converter { get; set; }
        protected Type TargetType { get; set; }

        [SetUp]
        public virtual void Setup()
        {
            Converter = (T)Activator.CreateInstance(typeof(T));
        }

        protected object TestConvert(object value, object parameter = null)
        {
            try
            {
                return Converter.Convert(value, TargetType, parameter, CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
