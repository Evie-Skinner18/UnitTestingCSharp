using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.TestNinja.UnitTests.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_Scenario_ReturnTrue()
        {
            // arrange: create an instance of the Reservation class (a Reservation object)
            var reservation = new Reservation();

            // act: call a method that we want to test on the object. Need to get result and check it's correct
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //assert: check it's correct
            Assert.IsTrue(result);
        }
    }
}
