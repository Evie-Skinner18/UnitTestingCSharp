using System;
using NUnit.Framework;
using TestNinja.TestNinja.UnitTests.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class NUnitReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_Scenario_ReturnTrue()
        {
            // arrange: create an instance of the Reservation class (a Reservation object)
            var reservation = new Reservation();

            // act: call a method that we want to test on the object. Need to get result and check it's correct
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //assert: check it's correct. NUnit assertion reads like plain English
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserThatMadeReservation_ReturnTrue()
        {
            // arrange
            var user = new User();
            var reservation = new Reservation{MadeBy = user};

            // act
            var result = reservation.CanBeCancelledBy(user);

            // assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledByNonAdminUser_ReturnFalse()
        {
            var reservation = new Reservation();
            var result = reservation.CanBeCancelledBy(new User{IsAdmin = false});
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanBeCancelledByAnotherUserWhoDidNotMakeBooking_ReturnFalse()
        {
            var reservation = new Reservation { MadeBy = new User()};
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
    }
}
