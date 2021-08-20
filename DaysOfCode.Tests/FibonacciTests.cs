using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaysOfCode.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void Target10ShouldHaveLengthSeven()
        {

            Fibonacci fibonacci = new Fibonacci();

            List<int> result = fibonacci.FibSequence(10);

            Assert.AreEqual(7, result.Count);

        }

        [TestMethod]
        public void Target90CollectionShouldMatch()

        {
            Fibonacci fibonacci = new Fibonacci();

            List<int> expected = new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };

            List<int> result = fibonacci.FibSequence(90);

            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Target90CollectionWithAddedValueShouldFail()

        {
            Fibonacci fibonacci = new Fibonacci();

            List<int> expected = new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            List<int> result = fibonacci.FibSequence(90);

            CollectionAssert.AreNotEqual(expected, result);

        }

    }
}
