using DaysOfCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DaysOfCode.Tests
{
    [TestClass]
    public class SwapEndsTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4 }, new int[] { 4, 2, 3, 1 })]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [DataRow(new int[] { 8, 6, 7, 9, 5 }, new int[] {5,6,7,9,8})]
        [DataRow(new int[] { 1, 2}, new int[] { 2, 1 })]
        [DataRow(new int[] { 8, 6, 7, 9, 8 }, new int[] { 8, 6, 7, 9, 8 })]
        public void SwapEndsShouldReverseFirstAndLastOfArray(int[] nums, int[] expected)
        {
            //Arrange
            SwapEnds swapEnds = new SwapEnds();

            //Act
            int[] result = swapEnds.MakeSwappedArray(nums);

            //Assert

            Assert.IsNotNull(result);
            Assert.AreEqual(expected.Length, result.Length);

            for(int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
            
        }
    }
}


