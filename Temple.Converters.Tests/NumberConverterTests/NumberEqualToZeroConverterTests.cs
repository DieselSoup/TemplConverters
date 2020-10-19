using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Templ.Converters;
using Templ.Converters.Abstractions;

namespace Temple.Converters.Tests.NumberConverterTests
{
    public class NumberEqualToZeroConverterTests : BaseConverterTest<NumberEqualToZeroConverter>
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
            TargetType = typeof(bool);
        }

        [Test]
        public void NumberEqualToZeroConverter_Zero_ReturnsTrue()
        {
            bool zeroResult = (bool)TestConvert(0, TargetType);

            Assert.True(zeroResult);
        }

        [Test]
        public void NumberEqualToZeroConverter_One_RetursnFalse()
        {
            bool oneResult = (bool)TestConvert(1, TargetType);

            Assert.False(oneResult);
        }

        [Test]
        public void NumberEqualToZeroConverter_NegativeOne_RetursnFalse()
        {
            bool negativeOneResult = (bool)TestConvert(-1, TargetType);

            Assert.False(negativeOneResult);
        }

        [Test]
        public void NumberEqualToZeroConverter_doubleOne_RetursnFalse()
        {
            double one = 1.23456789d;

            bool doubleResult = (bool)TestConvert(one, TargetType);

            Assert.False(doubleResult);
        }

        [Test]
        public void NumberEqualToZeroConverter_doubleZero_RetursnTrue()
        {
            double one = 0.0000000d;

            bool doubleResult = (bool)TestConvert(one, TargetType);

            Assert.True(doubleResult);
        }

        [Test]
        public void NumberEqualToZeroConverter_stringZero_RetursnInvalidCastExceptionException()
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
        public void NumberEqualToZeroConverter_null_RetursnNullReferenceExceptionException()
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
