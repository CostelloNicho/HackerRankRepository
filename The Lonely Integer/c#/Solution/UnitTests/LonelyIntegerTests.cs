using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    [TestClass]
    public class LonelyIntegerTests
    {
        [TestMethod]
        public void LonelyIntegerTest1 ()
        {
            var testInts = new int[1]{5};

            var test = Solution.FindLonelyInteger(testInts);

            Assert.AreEqual(5,test);
        }

        [TestMethod]
        public void LonelyIntegerTest2()
        {
            var testInts = new int[5] { 10, 12, 10, 11, 12};

            var test = Solution.FindLonelyInteger(testInts);

            Assert.AreEqual(11, test);
            Assert.AreNotEqual(10, test);
            Assert.AreNotEqual(12, test);
        }
    }
}
