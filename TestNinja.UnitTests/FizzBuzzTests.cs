using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        [TestCase(7, "7")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]

        public void GetOutput_WhenCalled_ShoudlReturnCorrectString(int param, string expected)
        {
            var result = FizzBuzz.GetOutput(param);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetOutput_InputIsDivisableBy5_ReturnBuzz()
        {
            Assert.That(FizzBuzz.GetOutput(5), Is.EqualTo("Buzz"));
        }
        [Test]
        public void GetOutput_InputIsDivisableBy3_ReturnFizz()
        {
            Assert.That(FizzBuzz.GetOutput(6), Is.EqualTo("Fizz"));
        }
        [Test]
        public void GetOutput_InputIsDivisableBy3and5_ReturnFizzBuzz()
        {
            Assert.That(FizzBuzz.GetOutput(15), Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void GetOutput_InputIsNotDivisableBy3or5_ReturnInputAsString()
        {
            Assert.That(FizzBuzz.GetOutput(7), Is.EqualTo("7"));
        }
    }
}
