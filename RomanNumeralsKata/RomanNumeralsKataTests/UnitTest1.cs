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
            Assert.AreEqual("I", roman.oneToThree(1));
            Assert.AreEqual("II", roman.oneToThree(2));
            Assert.AreEqual("III", roman.oneToThree(3));
        }

        [TestMethod]
        public void return4to8Tests()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("IV", roman.oneToThree(4));
            Assert.AreEqual("V", roman.oneToThree(5));
            Assert.AreEqual("VI", roman.oneToThree(9));
            Assert.AreEqual("VII", roman.oneToThree(7));
            Assert.AreEqual("VIII", roman.oneToThree(8));
        }
    }
}
