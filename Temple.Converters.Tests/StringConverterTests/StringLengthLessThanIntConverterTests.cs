using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Templ.Converters.Tests.StringConverterTests
{
    public class StringLengthLessThanIntConverterTests:BaseConverterTest<StringLengthLessThanIntConverter>
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
            TargetType = typeof(string);
        }

        [Test]
        public void StringLengthLessThanIntConverterConverter_StringLength_ConvertsCorrectly()
        {
            string testValue = "aaaaa";
            string testWhitespace = "     ";

            bool lengthMatch = (bool)TestConvert(testValue, testValue.Length);
            bool lengthMismatchLess = (bool)TestConvert(testValue, testValue.Length - 1);
            bool lengthMismatchGreater = (bool)TestConvert(testValue, testValue.Length + 1);
            bool whitespaceMatch = (bool)TestConvert(testWhitespace, testWhitespace.Length);
            bool whitespaceMismatchLess = (bool)TestConvert(testWhitespace, testWhitespace.Length - 1);
            bool whitespaceMismatchGreater = (bool)TestConvert(testWhitespace, testWhitespace.Length + 1);

            Assert.False(lengthMatch);
            Assert.False(lengthMismatchLess);
            Assert.True(lengthMismatchGreater);

            Assert.False(whitespaceMatch);
            Assert.False(whitespaceMismatchLess);
            Assert.True(whitespaceMismatchGreater);
        }

        [Test]
        public void StringLengthLessThanIntConverterConverter_NullOrEmpty_ReturnsFalse()
        {
            string emptyValue = "";
            string nullValue = null;

            bool emptyResult = (bool)TestConvert(emptyValue, emptyValue.Length);
            bool nullResult = (bool)TestConvert(nullValue, 0);

            Assert.False(emptyResult);
            Assert.False(nullResult);
        }

        [Test]
        public void StringLengthLessThanIntConverterConverter_Number_ReturnsInvalidCastExceptionException()
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
