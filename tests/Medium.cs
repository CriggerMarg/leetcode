using Xunit;
using LeetMed = code.Medium;

namespace tests
{
    public class Medium
    {
        [Theory(DisplayName = "2. Add Two Numbers")]
        [InlineData(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
        [InlineData(new[] { 0 }, new[] { 1 }, new[] { 1 })]
        [InlineData(new[] { 5 }, new[] { 5 }, new[] { 0, 1 })]
        [InlineData(new[] { 9, 8 }, new[] { 1 }, new[] { 0, 9 })]
        public void AddTwoNumbers(int[] left, int[] right, int[] expected)
        {
            var l1 = utils.InitListNode(left);
            var l2 = utils.InitListNode(right);
            var etalone = utils.InitListNode(expected);
            var result = LeetMed.AddTwoNumbers(l1, l2);
            Assert.Equal(etalone, result);
        }

        [Theory(DisplayName = "3. Longest Substring Without Repeating Characters")]
        [InlineData(" ", 1)]
        [InlineData("dvdf", 3)]
        [InlineData("aab", 2)]
        [InlineData("ohomm", 3)]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void LengthOfLongestSubstring(string input, int expected)
        {
            Assert.Equal(expected, LeetMed.LengthOfLongestSubstring(input));
        }

        [Theory(DisplayName = "7. Reverse Integer")]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        public void Reverse(int input, int expected)
        {
            Assert.Equal(expected, LeetMed.Reverse(input));
        }

        [Theory(DisplayName = "11. Container With Most Water")]
        [InlineData(new[] { 1, 1 }, 1)]
        [InlineData(new[] { 2, 3, 4, 5, 18, 17, 6 }, 17)]
        [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        public void MaxArea(int[] height, int expected)
        {
            Assert.Equal(expected, LeetMed.MaxArea(height));
        }


        [Theory(DisplayName = "740. Delete and Earn")]
        [InlineData(new int[] { 3, 4, 2 }, 6)]
        [InlineData(new int[] { 2, 2, 3, 3, 3, 4 }, 9)]
        public void DeleteAndEarn(int[] input, int output)
        {
            Assert.Equal(output, LeetMed.DeleteAndEarn(input));
        }
    }
}