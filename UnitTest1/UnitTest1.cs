using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToDec;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res;
            res = RomanToDecimal.RomanToDec("DCCCXIX");
            Assert.AreEqual(819, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int res;
            res = RomanToDecimal.RomanToDec("CDXLIV");
            Assert.AreEqual(444, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int res;
            res = RomanToDecimal.RomanToDec("DCLXVI");
            Assert.AreEqual(666, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int res;
            res = RomanToDecimal.RomanToDec("MMCMXLIX");
            Assert.AreEqual(2949, res);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int res;
            res = RomanToDecimal.RomanToDec("COMRADE");
            Assert.AreEqual(0, res);
        }
    }
}
