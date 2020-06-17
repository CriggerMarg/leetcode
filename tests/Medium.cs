using NUnit.Framework;

using LeetMed = code.Medium;


namespace tests
{
    public class Medium
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new[] { 1, 1 }, 1)]
        [TestCase(new[] { 2, 3, 4, 5, 18, 17, 6 }, 17)]
        [TestCase(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        public void MaxArea(int[] height, int expected)
        {
            Assert.AreEqual(expected, LeetMed.MaxArea(height));
        }
    }
}