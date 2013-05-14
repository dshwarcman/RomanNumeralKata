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
            Assert.AreEqual("", roman.NumToRoman(0));
            Assert.AreEqual("I", roman.NumToRoman(1));
            Assert.AreEqual("II", roman.NumToRoman(2));
            Assert.AreEqual("III", roman.NumToRoman(3));
        }

        [TestMethod]
        public void return4to8Tests()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("IV", roman.NumToRoman(4));
            Assert.AreEqual("V", roman.NumToRoman(5));
            Assert.AreEqual("VI", roman.NumToRoman(6));
            Assert.AreEqual("VII", roman.NumToRoman(7));
            Assert.AreEqual("VIII", roman.NumToRoman(8));
        }
        [TestMethod]
        public void return9to13Tests()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("IX", roman.NumToRoman(9));
            Assert.AreEqual("X", roman.NumToRoman(10));
            Assert.AreEqual("XI", roman.NumToRoman(11));
            Assert.AreEqual("XII", roman.NumToRoman(12));
            Assert.AreEqual("XIII", roman.NumToRoman(13));
        }
        [TestMethod]
        public void return14to20Tests()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("XIV", roman.NumToRoman(14));
            Assert.AreEqual("XV", roman.NumToRoman(15));
            Assert.AreEqual("XVI", roman.NumToRoman(16));
            Assert.AreEqual("XVII", roman.NumToRoman(17));
            Assert.AreEqual("XVIII", roman.NumToRoman(17));
            Assert.AreEqual("XIX", roman.NumToRoman(19));
            Assert.AreEqual("XX", roman.NumToRoman(20));
        }
    }
}
