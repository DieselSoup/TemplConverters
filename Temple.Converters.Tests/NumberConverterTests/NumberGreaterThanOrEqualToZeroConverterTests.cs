using System;
using NUnit.Framework;
using Templ.Converters.Tests;

namespace Templ.Converters.Tests.NumberConverterTests
{
    public class NumberGreaterThanOrEqualToZeroConverterTests:BaseConverterTest<NumberGreaterThanOrEqualToZeroConverter>
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
            TargetType = typeof(bool);
        }

        [Test]
        public void NumberGreaterThanOrEqualToZeroCoverter_Zero_ReturnsTrue()
        {
            bool zeroResult = (bool)TestConvert(0, TargetType);

            Assert.True(zeroResult);
        }

        [Test]
        public void NumberGreaterThanOrEqualToZeroCoverter_One_ReturnsTrue()
        {
            bool oneResult = (bool)TestConvert(1, TargetType);

            Assert.True(oneResult);
        }

        [Test]
        public void NumberGreaterThanOrEqualToZeroCoverter_NegativeOne_ReturnsFalse()
        {
            bool negativeOneResult = (bool)TestConvert(-1, TargetType);

            Assert.False(negativeOneResult);
        }

        [Test]
        public void NumberGreaterThanOrEqualToZeroCoverter_doubleOne_ReturnsTrue()
        {
            double one = 1.23456789d;

            bool doubleResult = (bool)TestConvert(one, TargetType);

            Assert.True(doubleResult);
        }

        [Test]
        public void NumberGreaterThanOrEqualToZeroCoverter_doubleZero_ReturnsTrue()
        {
            double one = 0.0000000d;

            bool doubleResult = (bool)TestConvert(one, TargetType);

            Assert.True(doubleResult);
        }

        [Test]
        public void NumberGreaterThanOrEqualToZeroCoverter_stringZero_ReturnsInvalidCastExceptionException()
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
        public void NumberGreaterThanOrEqualToZeroCoverter_null_ReturnsNullReferenceExceptionException()
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
