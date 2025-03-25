using FluentAssertions;
using leetcode.HashTable.SlidingWindow;

namespace leetcode.tests.HashTable.SlidingWindow;
public class _3_Tests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("abccaabbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    public void TestCases(string input, int expected)
    {
        var test = new _3();
        var rez = test.LengthOfLongestSubstring(input);
        rez.Should().Be(expected);
    }
}
