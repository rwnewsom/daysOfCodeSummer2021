using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaysOfCode.Tests
{
    [TestClass]
    public class CheckPalindromeTests
    {
        [TestMethod]
        public void AabaaShouldReturnTrue()
        {
            CheckPalindrome checkPalindrome = new CheckPalindrome();
            string input = "aabaa";
            bool result = checkPalindrome.IsPalindrome(input);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void SyzygyShouldReturnFalse()
        {
            CheckPalindrome checkPalindrome = new CheckPalindrome();
            string input = "syzygy";
            bool result = checkPalindrome.IsPalindrome(input);

            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void AbacShouldReturnFalse()
        {
            CheckPalindrome checkPalindrome = new CheckPalindrome();
            string input = "abac";
            bool result = checkPalindrome.RecursivePalindromeChecker(input);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void RadarShouldReturnTrue()
        {
            CheckPalindrome checkPalindrome = new CheckPalindrome();
            string input = "radar";
            bool result = checkPalindrome.RecursivePalindromeChecker(input);

            Assert.AreEqual(true, result);
        }
    }
}
