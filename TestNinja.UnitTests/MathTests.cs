using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        [SetUp]
        public void BeforeEach()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnsTheSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]

        public void Max_WhenCalled_ReturnTheSecondArgument(int a, int b, int intexpected)
        {
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}