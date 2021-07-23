using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaysOfCode.Tests
{
    [TestClass]
    public class Array123Tests
    {
        [TestMethod]
        public void Arraywith11231ShouldReturnTrue()
        {
            Array123 array = new Array123();

            int[] nums = { 1, 1, 2, 3, 1 };
            bool result = array.Has123(nums);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Arraywith11243ShouldReturnFalse()
        {
            Array123 array = new Array123();

            int[] nums = { 1, 1, 2, 4, 3 };
            bool result = array.Has123(nums);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Arraywith11243ShouldReturnTrue()
        {
            Array123 array = new Array123();

            int[] nums = { 1, 1, 2, 1, 2, 3 };
            bool result = array.Has123(nums);

            Assert.AreEqual(true, result);
        }
        /// <summary>
        /// Edge case - identified out of range exception.
        /// </summary>
        [TestMethod]
        public void Arraywith1124312ShouldReturnFalse()
        {
            Array123 array = new Array123();

            int[] nums = { 1, 1, 2, 4, 3, 1, 2 };
            bool result = array.Has123(nums);

            Assert.AreEqual(false, result);
        }

    }
}
