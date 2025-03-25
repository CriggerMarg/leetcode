using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;
public class _125_ValidPalindromeTests
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    [InlineData(".,", true)]
    [InlineData("a.", true)]
    [InlineData("0P", false)]
    public void TestCases(string input, bool isValid)
    {
        var test = new _125();
        test.IsPalindrome(input).Should().Be(isValid);
    }
}
