using NUnit.Framework;
using System;
using Templ.Converters.Tests;

namespace Templ.Converters.Tests.NumberConverterTests
{
    public class NumberGreaterThanZeroConverterTests:BaseConverterTest<NumberGreaterThanZeroConverter>
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
            TargetType = typeof(bool);
        }

        [Test]
        public void NumberGreaterThanZeroCoverter_Zero_ReturnsFalse()
        {
            bool zeroResult = (bool)TestConvert(0, TargetType);

            Assert.False(zeroResult);
        }

        [Test]
        public void NumberGreaterThanZeroCoverter_One_ReturnsTrue()
        {
            bool oneResult = (bool)TestConvert(1, TargetType);

            Assert.True(oneResult);
        }

        [Test]
        public void NumberGreaterThanZeroCoverter_NegativeOne_ReturnsFalse()
        {
            bool negativeOneResult = (bool)TestConvert(-1, TargetType);

            Assert.False(negativeOneResult);
        }

        [Test]
        public void NumberGreaterThanZeroCoverter_doubleOne_ReturnsTrue()
        {
            double one = 1.23456789d;

            bool doubleResult = (bool)TestConvert(one, TargetType);

            Assert.True(doubleResult);
        }

        [Test]
        public void NumberGreaterThanZeroCoverter_doubleZero_ReturnsFalse()
        {
            double one = 0.0000000d;

            bool doubleResult = (bool)TestConvert(one, TargetType);

            Assert.False(doubleResult);
        }

        [Test]
        public void NumberGreaterThanZeroCoverter_stringZero_ReturnsInvalidCastExceptionException()
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
        public void NumberGreaterThanZeroCoverter_null_ReturnsNullReferenceExceptionException()
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
