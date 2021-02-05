using NUnit.Framework;
using System;
using Templ.Converters.Tests;

namespace Templ.Converters.Tests.NumberConverterTests
{
    public class NumberLessThanZeroConverterTests:BaseConverterTest<NumberLessThanZeroConverter>
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
            TargetType = typeof(bool);
        }

        [Test]
        public void NumberLessThanZeroConverter_Zero_ReturnsFalse()
        {
            bool zeroResult = (bool)TestConvert(0, TargetType);

            Assert.False(zeroResult);
        }

        [Test]
        public void NumberLessThanZeroConverter_One_ReturnsFalse()
        {
            bool oneResult = (bool)TestConvert(1, TargetType);

            Assert.False(oneResult);
        }

        [Test]
        public void NumberLessThanZeroConverter_NegativeOne_ReturnsTrue()
        {
            bool negativeOneResult = (bool)TestConvert(-1, TargetType);

            Assert.True(negativeOneResult);
        }

        [Test]
        public void NumberLessThanZeroConverter_doubleOne_ReturnsFalse()
        {
            double one = 1.23456789d;

            bool doubleResult = (bool)TestConvert(one, TargetType);

            Assert.False(doubleResult);
        }

        [Test]
        public void NumberLessThanZeroConverter_doubleZero_ReturnsFalse()
        {
            double one = 0.0000000d;

            bool doubleResult = (bool)TestConvert(one, TargetType);

            Assert.False(doubleResult);
        }

        [Test]
        public void NumberLessThanZeroConverter_stringZero_ReturnsInvalidCastExceptionException()
        {
            try
            {
                bool doubleResult = (bool)TestConvert("0", TargetType);
            }
            catch (Exception ex)
            {

                Assert.AreEqual(typeof(InvalidCastException), ex.GetType());
            }
        }

        [Test]
        public void NumberLessThanZeroConverter_null_ReturnsNullReferenceExceptionException()
        {
            try
            {
                bool doubleResult = (bool)TestConvert(null, TargetType);
            }
            catch (Exception ex)
            {

                Assert.AreEqual(typeof(NullReferenceException), ex.GetType());
            }
        }
    }
}
