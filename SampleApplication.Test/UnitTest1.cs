using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApplication;

namespace SampleApplication.Test
{
   [TestMethod]
        public void TestMethod1()
        {
           int expectedValue = 6;
           int actualValu= BusinessLayer.Add(3, 3);
           Assert.AreEqual(expectedValue, actualValu);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int expectedValue = 6;
            int actualValu = BusinessLayer.Add(3, 3);
            Assert.AreEqual(expectedValue, actualValu);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int expectedValue = 7;
            int actualValu = BusinessLayer.Add(3, 3);
            Assert.AreEqual(expectedValue, actualValu);
        }
}
