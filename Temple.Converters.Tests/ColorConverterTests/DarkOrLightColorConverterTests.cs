using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Templ.Converters.ColorConverters;
using Xamarin.Forms;

namespace Templ.Converters.Tests.ColorConverterTests
{
    public class DarkOrLightColorConverterTests:BaseConverterTest<DarkOrLightColorConverter>
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
            TargetType = typeof(Color);
        }

        [Test]
        public void DarkOrLightColorConverter_White_ReturnsBlack()
        {
            Color colorResult = (Color)TestConvert(Color.White, typeof(Color));

            Assert.AreEqual(Color.Black, colorResult);
        }

        [Test]
        public void DarkOrLightColorConverter_Black_ReturnsWhite()
        {
            Color colorResult = (Color)TestConvert(Color.Black, typeof(Color));

            Assert.AreEqual(Color.White, colorResult);
        }

        [Test]
        public void DarkOrLightColorConverter_LightColors_ReturnBlack()
        {
            Color lightYellowResult = (Color)TestConvert(Color.LightYellow, typeof(Color));
            Color lightCyanResult = (Color)TestConvert(Color.LightCyan, typeof(Color));
            Color WhiteSmokeResult = (Color)TestConvert(Color.WhiteSmoke, typeof(Color));

            Assert.AreEqual(Color.Black, lightYellowResult);
            Assert.AreEqual(Color.Black, lightCyanResult);
            Assert.AreEqual(Color.Black, WhiteSmokeResult);
        }

        [Test]
        public void DarkOrLightColorConverter_DarkColors_ReturnWhite()
        {
            Color redResult = (Color)TestConvert(Color.Red, typeof(Color));
            Color blueResult = (Color)TestConvert(Color.Blue, typeof(Color));
            Color greenResult = (Color)TestConvert(Color.Green, typeof(Color));

            Assert.AreEqual(Color.White, redResult);
            Assert.AreEqual(Color.White, blueResult);
            Assert.AreEqual(Color.White, greenResult);
        }
    }
}
