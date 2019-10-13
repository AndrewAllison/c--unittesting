using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_WhenSpeedIsOutOfRange_ThrowsArgumentOutOfRangeException(int speed)
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            Assert.That(() => demeritPointsCalculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(67, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]

        public void CalculateDemeritPoints_WhenCalled_DeterminePoints(int speed, int points)
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            var result = demeritPointsCalculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(points));
        }
    }
}
