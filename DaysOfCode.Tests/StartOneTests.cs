using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaysOfCode.Tests
{
    [TestClass]
    public class StartOneTests
    {
        [TestMethod]
        public void TwoArraysWithOneAsFirstElementShouldReturnTwo()
        {
            StartOne startOne = new StartOne();

            int[] a = { 1, 3, 1 };
            int[] b = { 1, 1, 9 };

            int result = startOne.StartOneCount(a,b);

            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TwoArraysWithoutOneAsFirstElementsShouldReturnZero()
        {
            StartOne startOne = new StartOne();

            int[] a = { 6, 3, 7 };
            int[] b = { 5, 2, 9 };

            int result = startOne.StartOneCount(a, b);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TwoArraysOneWithandOneWithoutOneAsFirstElementsShouldReturnOne()
        {
            StartOne startOne = new StartOne();

            int[] a = { 1, 3, 7 };
            int[] b = { 5, 2, 9 };

            int result = startOne.StartOneCount(a, b);

            Assert.AreEqual(1, result);
        }


    }
}
