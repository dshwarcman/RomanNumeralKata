using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsKata;

namespace RomanNumeralsKataTests
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        RomanNumerals roman = new RomanNumerals();
        public void return1to3Tests()
        {
            Assert.AreEqual("I", roman.oneToThree(1));
            Assert.AreEqual("II", roman.oneToThree(2));
            Assert.AreEqual("III", roman.oneToThree(3));
        }
        public void return4to8Tests()
        {
            Assert.AreEqual("IV", roman.oneToThree(4));
            Assert.AreEqual("V", roman.oneToThree(5));
            Assert.AreEqual("VI", roman.oneToThree(6));
            Assert.AreEqual("VII", roman.oneToThree(7));
            Assert.AreEqual("VIII", roman.oneToThree(8));
        }
    }
}
