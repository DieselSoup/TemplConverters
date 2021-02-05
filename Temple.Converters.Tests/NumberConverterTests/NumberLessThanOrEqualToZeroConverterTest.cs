using System;
using NUnit.Framework;
using Templ.Converters.Tests;

namespace Templ.Converters.Tests.NumberConverterTests
{
    public class NumberLessThanOrEqualToZeroConverterTest:BaseConverterTest<NumberLessThanOrEqualToZeroConverter>
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
            TargetType = typeof(bool);
        }

        [Test]
        public void NumberLessThanOrEqualToZeroConverter_Zero_ReturnsTrue()
        {
            bool zeroResult = (bool)TestConvert(0, TargetType);

            Assert.True(zeroResult);
        }

        [Test]
        public void NumberLessThanOrEqualToZeroConverter_One_ReturnsFalse()
        {
            bool oneResult = (bool)TestConvert(1, TargetType);

            Assert.False(oneResult);
        }

        [Test]
        public void NumberLessThanOrEqualToZeroConverter_NegativeOne_ReturnsTrue()
        {
            bool negativeOneResult = (bool)TestConvert(-1, TargetType);

            Assert.True(negativeOneResult);
        }

        [Test]
        public void NumberLessThanOrEqualToZeroConverter_doubleOne_ReturnsFalse()
        {
            double one = 1.23456789d;

            bool doubleResult = (bool)TestConvert(one, TargetType);

            Assert.False(doubleResult);
        }

        [Test]
        public void NumberLessThanOrEqualToZeroConverter_doubleZero_ReturnsTrue()
        {
            double one = 0.0000000d;

            bool doubleResult = (bool)TestConvert(one, TargetType);

            Assert.True(doubleResult);
        }

        [Test]
        public void NumberLessThanOrEqualToZeroConverter_stringZero_ReturnsInvalidCastExceptionException()
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
        public void NumberLessThanOrEqualToZeroConverter_null_ReturnsNullReferenceExceptionException()
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
