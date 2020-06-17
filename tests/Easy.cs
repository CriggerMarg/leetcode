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

    }
}