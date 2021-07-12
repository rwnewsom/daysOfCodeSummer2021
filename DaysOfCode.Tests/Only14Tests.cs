using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaysOfCode.Tests
{
    [TestClass]
    public class Only14Tests
    {
        [TestMethod]
        public void ArrayIncludingThreeShouldReturnFalse()
        {
            Only14 only14 = new Only14();

            int[] nums = { 1, 4, 1, 1, 4, 3, 1, 4, 4 };

            bool actual = only14.isOnlyOneFour(nums);

            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArrayWithOnlyOnesShouldReturnTrue()
        {
            Only14 only14 = new Only14();

            int[] nums = { 1, 1, 1, 1, 1 };

            bool actual = only14.isOnlyOneFour(nums);

            bool expected = true;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ArrayWithOnlyFoursShouldReturnTrue()
        {
            Only14 only14 = new Only14();

            int[] nums = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };

            bool actual = only14.isOnlyOneFour(nums);

            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArrayWithOnesAndFoursShouldReturnTrue()
        {
            Only14 only14 = new Only14();

            int[] nums = { 4, 1, 4, 1, 4, 4, 4, 1, 4, 4, 4, 4, 1 };

            bool actual = only14.isOnlyOneFour(nums);

            bool expected = true;

            Assert.AreEqual(expected, actual);
        }


    }
}
