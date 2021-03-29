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
            Color result = (Color)TestConvert(Color.FromHex("#FF00FF"), typeof(Color));

            Assert.AreEqual(Color.FromHex("00FF00"), result);
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
    }
}
