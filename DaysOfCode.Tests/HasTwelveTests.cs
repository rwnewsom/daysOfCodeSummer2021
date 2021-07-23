using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaysOfCode.Tests
{
    [TestClass]
    public class HasTwelveTests
    {
        [TestMethod]
        public void ArrayWithOneThenTwoShouldReturnTrue()
        {            
            HasTwelve hasTwelve = new HasTwelve();
            int[] nums = { 1, 3, 5, 2 };
            bool result = hasTwelve.HasOneThenTwo(nums);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void ArrayWithTwoThenOneShouldReturnFalse()
        {
            HasTwelve hasTwelve = new HasTwelve();
            int[] nums = { 2, 3, 5, 1 };
            bool result = hasTwelve.HasOneThenTwo(nums);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ArrayWithNeitherTwoNorOneShouldReturnFalse()
        {
            HasTwelve hasTwelve = new HasTwelve();
            int[] nums = { 8, 3, 5, 9 };
            bool result = hasTwelve.HasOneThenTwo(nums);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ArrayWithOneButNotTwoShouldReturnFalse()
        {
            HasTwelve hasTwelve = new HasTwelve();
            int[] nums = { 8, 1, 5, 9 };
            bool result = hasTwelve.HasOneThenTwo(nums);
            Assert.AreEqual(false, result);
        }
    }
}
