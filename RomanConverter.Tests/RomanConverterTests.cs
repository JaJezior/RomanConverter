using NUnit.Framework;

namespace RomanConverter.Tests
{
    public class RomanConverterTests
    {
        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        [TestCase("II", 2)]
        [TestCase("VI", 6)]
        [TestCase("CDXLIV", 444)]
        [TestCase("DCLXVI", 666)]
        [TestCase("MMMCMXCIX", 3999)]
        public void ReturnsCorrectArabicNumber(string romanInput, int expectedResult)
        {
            var romanConverter = new RomanConverter();

            int result = romanConverter.ConvertToArabic(romanInput);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("MMXIX", true)]
        [TestCase("XIXM", false)]
        [TestCase("AAFGIIM", false)]
        [TestCase("xxiv", false)]
        [TestCase("MMMCMXCIX", true)]
        public void ValidateInputReturnsCorrectBool (string input, bool expectedResult)
        {
            var romanNumberValidator = new RomanNumberValidator();
            
            var result = romanNumberValidator.ValidateInput(input);

            Assert.That(result == expectedResult);
        }
    }
}
