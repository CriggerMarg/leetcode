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
    }
}