using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Templ.Converters.Tests.StringConverterTests
{
    public class StringLengthEqualsIntConverterTests:BaseConverterTest<StringLengthEqualsIntConverter>
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
            TargetType = typeof(string);
        }

        [Test]
        public void StringLengthEqualsIntConverter_StringLength_ConvertsCorrectly()
        {
            string testValue = "aaaaa";
            string testWhitespace = "     ";

            bool lengthMatch = (bool)TestConvert(testValue, testValue.Length);
            bool lengthMismatch = (bool)TestConvert(testValue, testValue.Length + 1);
            bool whitespaceMatch = (bool)TestConvert(testWhitespace, testWhitespace.Length);
            bool whitespaceMismatch = (bool)TestConvert(testWhitespace, testWhitespace.Length + 1);

            Assert.True(lengthMatch);
            Assert.False(lengthMismatch);
            Assert.True(whitespaceMatch);
            Assert.False(whitespaceMismatch);
        }

        [Test]
        public void StringLengthEqualsIntConverter_NullOrEmpty_ReturnsFalse()
        {
            string emptyValue = "";
            string nullValue = null;

            bool emptyResult = (bool)TestConvert(emptyValue, emptyValue.Length);
            bool nullResult = (bool)TestConvert(nullValue, 0);

            Assert.False(emptyResult);
            Assert.False(nullResult);
        }

        [Test]
        public void StringLengthEqualsIntConverter_Number_ReturnsInvalidCastExceptionException()
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
