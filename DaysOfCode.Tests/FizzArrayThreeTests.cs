using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaysOfCode.Tests
{
    [TestClass]
    public class FizzArrayThreeTests
    {
        [TestMethod]
        public void FiveAndTenShouldHaveLengthFive()
        {
            FizzArrayThree fizzArrayThree = new FizzArrayThree();

            int[] result = fizzArrayThree.MakeFizzArray(5, 10);

            Assert.AreEqual(5, result.Length);
        }

        [TestMethod]
        public void FiveAndTenShouldYieldFiveThruNine()
        {
            FizzArrayThree fizzArrayThree = new FizzArrayThree();
            int[] expected = { 5, 6, 7, 8, 9 };

            int[] result = fizzArrayThree.MakeFizzArray(5, 10);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ElevenAndEighteenShouldYieldElevenThruSeventeen()
        {
            FizzArrayThree fizzArrayThree = new FizzArrayThree();
            int[] expected = { 11, 12, 13, 14, 15, 16, 17 };

            int[] result = fizzArrayThree.MakeFizzArray(11, 18);

            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod]
        public void OneAndThreeShouldYieldOneToTwo()
        {
            FizzArrayThree fizzArrayThree = new FizzArrayThree();
            int[] expected = { 1,2 };

            int[] result = fizzArrayThree.MakeFizzArray(1, 3);

            CollectionAssert.AreEqual(expected, result);

        }

    }
}
