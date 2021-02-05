using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Templ.Converters.Tests.StringConverterTests
{
    public class StringIsNullOrEmptyToBoolConverterTests:BaseConverterTest<StringIsNullOrEmptyToBoolConverter>
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
            TargetType = typeof(string);
        }

        [Test]
        public void StringIsNullOrEmptyToBoolConverter_EmptyString_ReturnsFalse()
        {
            bool emptyResult = (bool)TestConvert("", TargetType);

            Assert.False(emptyResult);
        }

        [Test]
        public void StringIsNullOrEmptyToBoolConverter_String_ReturnsFalse()
        {
            bool stringResult = (bool)TestConvert("string", TargetType);

            Assert.True(stringResult);
        }

        [Test]
        public void StringIsNullOrEmptyToBoolConverter_Null_ReturnsFalse()
        {
            bool nullResult = (bool)TestConvert(null, TargetType);

            Assert.False(nullResult);
        }

        [Test]
        public void StringIsNullOrEmptyToBoolConverter_Number_ReturnsInvalidCastExceptionException()
        {
            try
            {
                bool doubleResult = (bool)TestConvert(0, TargetType);
            }
            catch (Exception ex)
            {

                Assert.AreEqual(typeof(InvalidCastException), ex.GetType());
            }
        }
    }
}
