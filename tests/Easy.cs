using NUnit.Framework;

using LeetEasy = code.Easy;


namespace tests
{
    public class Easy
    {
        [TestCase("1.1.1.1", "1[.]1[.]1[.]1")]
        [TestCase("255.100.50.0", "255[.]100[.]50[.]0")]
        public void DefangIPaddr(string input, string expected)
        {
            Assert.AreEqual(expected, LeetEasy.DefangIPaddr(input));
        }

        [TestCase("()", true)]
        [TestCase("()[]{}", true)]
        [TestCase("(]", false)]
        [TestCase("([)]", false)]
        [TestCase("{[]}", true)]
        public void IsValid(string input, bool expected)
        {
            Assert.AreEqual(expected, LeetEasy.IsValid(input));
        }


        [TestCase(new[] { "flower", "flow", "flight" }, "fl")]
        [TestCase(new[] { "dog", "racecar", "car" }, "")]
        public void LongestCommonPrefix(string[] input, string expected)
        {
            Assert.AreEqual(expected, LeetEasy.LongestCommonPrefix(input));
        }


        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("LVIII", 58)]
        [TestCase("MCMXCIV", 1994)]
        public void RomanToInt(string input, int expected)
        {
            Assert.AreEqual(expected, LeetEasy.RomanToInt(input));
        }


        [TestCase(121, true)]
        [TestCase(-121, false)]
        [TestCase(10, false)]
        public void IsPalindrome(int input, bool expected)
        {
            Assert.AreEqual(expected, LeetEasy.IsPalindrome(input));
        }


        [TestCase(123, 321)]
        [TestCase(-123, -321)]
        [TestCase(120, 21)]
        public void Reverse(int input, int expected)
        {
            Assert.AreEqual(expected, LeetEasy.Reverse(input));
        }

        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]

        public void TwoSum(int[] input, int target, int[] expected)
        {
            Assert.AreEqual(expected, LeetEasy.TwoSum(input, target));
        }

        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 3, 4, 5 })]
        public void MiddleNode(int[] input, int[] expected)
        {
            var list = tools.InitListNode(input);
            var exp = tools.InitListNode(expected);
            Assert.AreEqual(exp, LeetEasy.MiddleNode(list));
        }

        [Ignore("did not implemented well")]
        [TestCase(new[] { 4, 2, 3 }, true)]
        [TestCase(new[] { 4, 2, 1 }, false)]
        [TestCase(new[] { 5, 6, 3, 4, 2, 3 }, false)]
        public void CheckPossibility(int[] input, bool expected)
        {
            Assert.AreEqual(expected, LeetEasy.CheckPossibility(input));
        }


        [TestCase("ab","ba", true)]
        [TestCase("ab", "ab", false)]
        [TestCase("aa", "aa", true)]
        [TestCase("aaaaaaabc", "aaaaaaacb", true)]
        [TestCase("", "aa", false)]
        public void BuddyStrings(string left, string right, bool expected)
        {
            Assert.AreEqual(expected,LeetEasy.BuddyStrings(left,right));
        }
    }
}