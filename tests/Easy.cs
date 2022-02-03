using Xunit;
using LeetEasy = code.Easy;


namespace tests
{
    public class Easy
    {

        [Theory(DisplayName = "1. Two Sum")]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]

        public void TwoSum(int[] input, int target, int[] expected)
        {
            Assert.Equal(expected, LeetEasy.TwoSum(input, target));
        }

        [Theory(DisplayName = "9. Palindrome Number")]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void IsPalindrome(int input, bool expected)
        {
            Assert.Equal(expected, LeetEasy.IsPalindrome(input));
        }

        [Theory(DisplayName = "13. Roman to Integer")]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void RomanToInt(string input, int expected)
        {
            Assert.Equal(expected, LeetEasy.RomanToInt(input));
        }

        [Theory(DisplayName = "14. Longest Common Prefix")]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        public void LongestCommonPrefix(string[] input, string expected)
        {
            Assert.Equal(expected, LeetEasy.LongestCommonPrefix(input));
        }

        [Theory(DisplayName = "20. Valid Parentheses")]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        [InlineData("{[]}", true)]
        public void IsValid(string input, bool expected)
        {
            Assert.Equal(expected, LeetEasy.IsValid(input));
        }

        [Theory(DisplayName = "278. First Bad Version")]
        [InlineData(5, 4)]
        public void FirstBadVersion(int input, int output)
        {
            var fbv = new LeetEasy._278_first_bad_version(output);
            Assert.Equal(output, fbv.FirstBadVersion(input));
        }

        [Theory(DisplayName = "374. Guess Number Higher or Lower")]
        [InlineData(3, 2)]
        public void GuessNumber(int input, int output)
        {
            var t = new LeetEasy._374_guess_game(output);
            Assert.Equal(output, t.GuessNumber(input));
        }

        [Theory(DisplayName = "746. Min Cost Climbing Stairs")]
        [InlineData(new int[] { 10, 15, 20 }, 15)]
        [InlineData(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, 6)]
        public void MinCostClimbingStairs(int[] input, int output)
        {
            Assert.Equal(output, LeetEasy.MinCostClimbingStairs(input));
        }

        [Theory(DisplayName = "876. Middle of the Linked List")]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 3, 4, 5 })]
        public void MiddleNode(int[] input, int[] expected)
        {
            var list = utils.InitListNode(input);
            var exp = utils.InitListNode(expected);
            Assert.Equal(exp, LeetEasy.MiddleNode(list));
        }

        [Theory(DisplayName = "1108. Defanging an IP Address")]
        [InlineData("1.1.1.1", "1[.]1[.]1[.]1")]
        [InlineData("255.100.50.0", "255[.]100[.]50[.]0")]
        public void DefangIPaddr(string input, string expected)
        {
            Assert.Equal(expected, LeetEasy.DefangIPaddr(input));
        }

        [Theory(DisplayName = "1137. N-th Tribonacci Number")]
        [InlineData(4, 4)]
        [InlineData(3, 2)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(25, 1389537)]
        public void Tribonacci(int input, int output)
        {
            Assert.Equal(output, LeetEasy.Tribonacci(input));
        }


    }
}