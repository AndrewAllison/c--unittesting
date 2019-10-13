using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            var reservation = new Reservation();
            
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            
            Assert.That(result, Is.True);
        }
       
        [Test]
        public void CanBeCancelledBy_SameUserCancelsReservation_ReturnsTrue()
        {
            var reservation = new Reservation();
            var user = new User { IsAdmin = false };

            reservation.MadeBy = user;
            
            var result = reservation.CanBeCancelledBy(user);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsTrue()
        {
            var reservation = new Reservation();
            var user = new User { IsAdmin = false };
            reservation.MadeBy = user;

            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });


            Assert.That(result, Is.False);

        }
    }
}
