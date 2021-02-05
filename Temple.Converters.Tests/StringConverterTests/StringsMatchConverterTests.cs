using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Templ.Converters.Tests.StringConverterTests
{
    public class StringsMatchConverterTests:BaseConverterTest<StringsMatchConverter>
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
            TargetType = typeof(string);
        }

        [Test]
        public void StringsMatchConverter_SameStrings_ReturnTrue()
        {
            string stringValue = "test";
            string whitespaceValue = "    ";

            bool stringValueMatch = (bool)TestConvert(stringValue, stringValue);
            bool whitespaceValueMatch = (bool)TestConvert(whitespaceValue, whitespaceValue);

            Assert.True(stringValueMatch);
            Assert.True(whitespaceValueMatch);
        }

        [Test]
        public void StringsMatchConverter_DifferentString_ReturnFalse()
        {
            string stringValue1 = "test1";
            string stringValue2 = "test2";
            string whitespaceValue1 = "    ";
            string whitespaceValue2 = "";

            bool stringValueMatch = (bool)TestConvert(stringValue1, stringValue2);
            bool whitespaceValueMatch = (bool)TestConvert(whitespaceValue1, whitespaceValue2);

            Assert.False(stringValueMatch);
            Assert.False(whitespaceValueMatch);
        }

        [Test]
        public void StringsMatchConverter_Null_ReturnFalse()
        {
            string nullValue = null;

            bool nullValueMatch = (bool)TestConvert(nullValue, " ");

            Assert.False(nullValueMatch);
        }

        [Test]
        public void StringsMatchConverter_Number_ReturnsInvalidCastExceptionException()
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
