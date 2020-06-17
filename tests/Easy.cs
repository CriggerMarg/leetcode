using NUnit.Framework;

using LeetEasy = code.Easy;


namespace tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

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
    }
}