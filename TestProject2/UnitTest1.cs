using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebApplication2;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Tutorial tp = new Tutorial();
            Assert.AreEqual(tp.Name, "Hello, This is a demo app");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Tutorial tp = new Tutorial();
            Assert.AreEqual(tp.Mean(new int[] { 3, 7, 6, 1, 5 }), (float)4.4);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Tutorial tp = new Tutorial();
            Assert.AreEqual(tp.Median(new int[] { 3, 7, 6, 1, 5 }), 5);
        }
    }
}
