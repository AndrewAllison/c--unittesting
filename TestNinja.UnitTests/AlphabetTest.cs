using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class AlphabetTests
    {
        [Test]
        public void FindLongestPatter_WithASimplePatter_ReturnsCorrectResult()
        {
            var alphabetize = new Alphabetize();
            var stringItem = "xxxwxyasdkajdhakfksfjh";
            var result = alphabetize.FindLongestSequense(stringItem);
            Assert.That(result, Is.EqualTo("wxy"));
        }
    }
}
