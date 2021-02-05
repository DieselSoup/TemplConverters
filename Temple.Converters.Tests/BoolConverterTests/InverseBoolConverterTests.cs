using Templ.Converters;
using NUnit.Framework;
using System.Globalization;
using System;

namespace Templ.Converters.Tests.BoolConverterTests
{
    public class InverseBoolConverterTests
    {
        private InverseBoolConverter inverseBoolConverter { get; set; }
        private bool valueTrue { get; set; }
        private bool valueFalse { get; set; }
        private object valueNull { get; set; }
        private string valueEmptyString { get; set; }
        private string valueTrueString { get; set; }
        private string valueFalseString { get; set; }
        private string valueRandomString { get; set; }

        [SetUp]
        public void Setup()
        {
            valueTrue = true;
            valueFalse = false;
            valueNull = null;
        }

        [Test]
        public void InverseBoolConverter_ReturnsInverseBool()
        {
            inverseBoolConverter = new InverseBoolConverter();

            bool testConvertFalse = (bool)inverseBoolConverter.Convert(valueFalse, typeof(bool), null, CultureInfo.CurrentCulture);
            bool testConvertTrue= (bool)inverseBoolConverter.Convert(valueTrue, typeof(bool), null, CultureInfo.CurrentCulture);
            bool testConvertBackFalse = (bool)inverseBoolConverter.ConvertBack(valueFalse, typeof(bool), null, CultureInfo.CurrentCulture);
            bool testConvertBackTrue = (bool)inverseBoolConverter.ConvertBack(valueTrue, typeof(bool), null, CultureInfo.CurrentCulture);


            Assert.IsTrue(testConvertFalse);
            Assert.IsFalse(testConvertTrue);
            Assert.IsTrue(testConvertBackFalse);
            Assert.IsFalse(testConvertBackTrue);
        }

        [Test]
        public void InverseBoolConverter_HandlesNullInput_ExpectedNullReferenceExcpetion()
        {
            inverseBoolConverter = new InverseBoolConverter();
            object testConvertNull;

            try
            {
                testConvertNull = inverseBoolConverter.Convert(valueNull, typeof(bool), null, CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(typeof(NullReferenceException), ex.GetType());
            }

            try
            {
                testConvertNull = inverseBoolConverter.ConvertBack(valueNull, typeof(bool), null, CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(typeof(NullReferenceException), ex.GetType());
            }
        }

        [Test]
        public void InverseBoolConverter_HandlesStringInput_ExpectedInvalidCastExcpetion()
        {
            inverseBoolConverter = new InverseBoolConverter();

            valueEmptyString = "";
            valueRandomString = "asdsadagsd";
            valueTrueString = "true";
            valueFalseString = "False";

            try
            {
                bool testEmptyString = (bool)inverseBoolConverter.Convert(valueEmptyString, typeof(bool), null, CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {

                Assert.AreEqual(typeof(InvalidCastException), ex.GetType());
            }

            try
            {
                bool testRandomString = (bool)inverseBoolConverter.Convert(valueRandomString, typeof(bool), null, CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {

                Assert.AreEqual(typeof(InvalidCastException), ex.GetType());
            }

            try
            {
                bool testTrueString = (bool)inverseBoolConverter.Convert(valueTrueString, typeof(bool), null, CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {

                Assert.AreEqual(typeof(InvalidCastException), ex.GetType());
            }

            try
            {
                bool testFalseString = (bool)inverseBoolConverter.Convert(valueFalseString, typeof(bool), null, CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {

                Assert.AreEqual(typeof(InvalidCastException), ex.GetType());
            }
        }
    }
}