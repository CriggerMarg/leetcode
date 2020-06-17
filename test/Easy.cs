using NUnit.Framework;
using LEasy = LeetCode.Code.Easy;

namespace LeetCode.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new[] { 4, 2, 3 }, true)]
        [TestCase(new[] { 4, 2, 1 }, false)]
        public void CheckPossibility(int[] nums, bool expected)
        {
            Assert.AreEqual(expected, LEasy.CheckPossibility(nums));
        }
    }
}