using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsKata;

namespace RomanNumeralsKataTests
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void return1to3Tests()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("I", roman.oneToEight(1));
            Assert.AreEqual("II", roman.oneToEight(2));
            Assert.AreEqual("III", roman.oneToEight(3));
        }

        [TestMethod]
        public void return4to8Tests()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("IV", roman.oneToEight(4));
            Assert.AreEqual("V", roman.oneToEight(5));
            Assert.AreEqual("VI", roman.oneToEight(6));
            Assert.AreEqual("VII", roman.oneToEight(7));
            Assert.AreEqual("X", roman.oneToEight(8));
        }
    }
}
