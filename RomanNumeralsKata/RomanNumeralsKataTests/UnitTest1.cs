﻿using System;
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
    }
}
