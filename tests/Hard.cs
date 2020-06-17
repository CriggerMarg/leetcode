using NUnit.Framework;

using LeetHard = code.Hard;

namespace tests
{
    public class Hard
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(new int[0] , new[] { 1 }, 1)]
        [TestCase(new[] { 3 }, new[] { -2, -1 }, -1)]
        [TestCase(new[] { 1, 3, }, new[] { 2 }, 2.0)]
        [TestCase(new[] { 1, 2, }, new[] { 3, 4 }, 2.5)]
        public void FindMedianSortedArrays(int[] left, int[] right, double expected)
        {
            Assert.AreEqual(expected, LeetHard.FindMedianSortedArrays(left, right));
        }
    }
}