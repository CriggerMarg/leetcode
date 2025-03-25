using FluentAssertions;
using leetcode.Stack;

namespace leetcode.tests.Stack;
public class _1544Tests
{
    [Theory]
    [InlineData("leEeetcode", "leetcode")]
    [InlineData("abBAcC", "")]
    [InlineData("s", "s")]
    [InlineData("Pp", "")]
    public void TestCases(string input, string expected)
    {
        var test = new _1544();
        var rez = test.MakeGood(input);
        rez.Should().Be(expected);
    }
}
