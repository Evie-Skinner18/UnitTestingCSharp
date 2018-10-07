using System;
using NUnit.Framework;
using TestNinja.TestNinja.UnitTests.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class NUnitMathsTests
    {
        [Test]
        public void CanAddOnePlusOne_ShouldReturn2()
        {
            var maths = new Maths();
            var result = maths.Add(1, 1);
            Assert.AreEqual(1, result);
        }
    }
}
