using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Templ.Converters.ColorConverters;
using Xamarin.Forms;

namespace Templ.Converters.Tests.ColorConverterTests
{
    public class ComplimentaryColorConverterTests : BaseConverterTest<ComplimentaryColorConverter>
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
            TargetType = typeof(Color);
        }

        [Test]
        public void ComplimentaryColorConverter_FF00FF_Returns00FF00()
        {
            Color result = (Color)TestConvert(Color.FromHex("#FF00FF"), typeof(Color)); // Magenta

            Assert.AreEqual(Color.FromHex("00FF00"), result); // Green
        }

        [Test]
        public void ComplimentaryColorConverter_ReverseConvert_ReturnsCorrectResult()
        {
            Color baseColor = Color.FromHex("#0000FF");

            Color resultColor = (Color)TestConvert(baseColor, typeof(Color));
            Color reverseColor = (Color)TestConvert(resultColor, typeof(Color));

            Assert.AreEqual(Color.FromHex("#FFFF00"), resultColor);
            Assert.AreEqual(baseColor, reverseColor);
        }

        [Test]
        public void ComplimentaryColorConverter_Color_Red_ReturnsCyan()
        {
            Color red = Color.Red;

            Color resultColor = (Color)TestConvert(red, typeof(Color));

            Assert.AreEqual(resultColor, Color.Cyan);
        }

        [Test]
        public void ComplimentaryColorConverter_Color_Green_ReturnsLightMagenta()
        {
            //Color green = Color.FromHex("#00FF00"); //Color.Green = #FF008000

            Color green = Color.Green;

            Color lightMagenta = Color.FromRgb(1, 0.498039186000824, 1); // Color.Magenta = {R = 1, G = 0, B = 1}

            Color resultColor = (Color)TestConvert(green, typeof(Color));

            Assert.AreEqual(resultColor, lightMagenta);
        }

        [Test]
        public void ComplimentaryColorConverter_Color_Blue_ReturnsYellow()
        {
            Color blue = Color.Blue;

            Color resultColor = (Color)TestConvert(blue, typeof(Color));

            Assert.AreEqual(resultColor, Color.Yellow);
        }

        [Test]
        public void ComplimentaryColorConverter_Null_ReturnsNullReferenceExceptionException()
        {
            try
            {
                Color resultColor = (Color)TestConvert(null, typeof(Color));
            }
            catch (Exception ex)
            {

                Assert.AreEqual(typeof(NullReferenceException), ex.GetType());
            }
        }

        [Test]
        public void ComplimentaryColorConverter_StringHex_ReturnsInvalidCastExceptionException()
        {
            try
            {
                Color resultColor = (Color)TestConvert("#FF0000", typeof(Color));
            }
            catch (Exception ex)
            {

                Assert.AreEqual(typeof(InvalidCastException), ex.GetType());
            }
        }

        [Test]
        public void ComplimentaryColorConverter_Int_ReturnsInvalidCastExceptionException()
        {
            try
            {
                Color resultColor = (Color)TestConvert(110011, typeof(Color));
            }
            catch (Exception ex)
            {

                Assert.AreEqual(typeof(InvalidCastException), ex.GetType());
            }
        }
    }
}
