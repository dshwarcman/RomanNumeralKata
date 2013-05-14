using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsKata;

namespace RomanNumeralsKataTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void return0to3Tests()
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
            Assert.AreEqual("XVIII", roman.NumToRoman(18));
            Assert.AreEqual("XIX", roman.NumToRoman(19));
            Assert.AreEqual("XX", roman.NumToRoman(20));
        }
        [TestMethod]
        public void return21to40Tests()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("XXI", roman.NumToRoman(21));
            Assert.AreEqual("XXII", roman.NumToRoman(22));
            Assert.AreEqual("XXIII", roman.NumToRoman(23));
            Assert.AreEqual("XXIV", roman.NumToRoman(24));
            Assert.AreEqual("XXV", roman.NumToRoman(25));
            Assert.AreEqual("XXVI", roman.NumToRoman(26));
            Assert.AreEqual("XXVII", roman.NumToRoman(27));
            Assert.AreEqual("XXVIII", roman.NumToRoman(28));
            Assert.AreEqual("XXIX", roman.NumToRoman(29));
            Assert.AreEqual("XXX", roman.NumToRoman(30));
            Assert.AreEqual("XXXI", roman.NumToRoman(31));
            Assert.AreEqual("XXXII", roman.NumToRoman(32));
            Assert.AreEqual("XXXIII", roman.NumToRoman(33));
            Assert.AreEqual("XXXIV", roman.NumToRoman(34));
            Assert.AreEqual("XXXV", roman.NumToRoman(35));
            Assert.AreEqual("XXXVI", roman.NumToRoman(36));
            Assert.AreEqual("XXXVII", roman.NumToRoman(37));
            Assert.AreEqual("XXXVIII", roman.NumToRoman(38));
            Assert.AreEqual("XXXIX", roman.NumToRoman(39));
            Assert.AreEqual("XL", roman.NumToRoman(40));
        }
        [TestMethod]
        public void return41to1000Tests()
        {
            RomanNumerals roman = new RomanNumerals();
            Assert.AreEqual("XLI", roman.NumToRoman(41));
            Assert.AreEqual("XLIX", roman.NumToRoman(49));
            Assert.AreEqual("LVII", roman.NumToRoman(57));
            Assert.AreEqual("LXIV", roman.NumToRoman(64));
            Assert.AreEqual("LXXIV", roman.NumToRoman(74));
            Assert.AreEqual("XC", roman.NumToRoman(90));
            Assert.AreEqual("XCIX", roman.NumToRoman(99));
            Assert.AreEqual("D", roman.NumToRoman(500));
            Assert.AreEqual("M", roman.NumToRoman(1000));
            Assert.AreEqual("MMMLXV", roman.NumToRoman(3065));
        }
    }
}