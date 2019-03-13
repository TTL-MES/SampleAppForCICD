using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApplication;

namespace SampleApplication.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           int expectedValue = 6;
           int actualValu= BusinessLayer.Add(3, 3);
           Assert.AreEqual(expectedValue, actualValu);
        }
    }
}
