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
        [TestCase(" ", 1)]
        [TestCase("dvdf", 3)]
        [TestCase("aab", 2)]
        [TestCase("ohomm", 3)]
        [TestCase("ohomm", 3)]
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        public void LengthOfLongestSubstring(string input, int expected)
        {
            Assert.AreEqual(expected, LeetMed.LengthOfLongestSubstring(input));
        }

    

        [TestCase(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
        [TestCase(new[] { 0 }, new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 5 }, new[] { 5 }, new[] { 0, 1 })]
        [TestCase(new[] { 9, 8 }, new[] { 1 }, new[] { 0, 9 })]
        public void AddTwoNumbers(int[] left, int[] right, int[] expected)
        {
            var l1 = tools.InitListNode(left);
            var l2 = tools.InitListNode(right);
            var etalone = tools.InitListNode(expected);
            var result = LeetMed.AddTwoNumbers(l1, l2);
            Assert.AreEqual(etalone, result);
        }


    }
}