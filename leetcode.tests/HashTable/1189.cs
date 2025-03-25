using FluentAssertions;
using leetcode.HashTable;

namespace leetcode.tests.HashTable;
public class _1189Tests
{
    [Theory]
    [InlineData("nlaebolko", 1)]
    [InlineData("loonbalxballpoon", 2)]
    [InlineData("leetcode", 0)]
    [InlineData("balon", 0)]
    public void TestCases(string input, int output)
    {
        var test = new _1189();
        var rez = test.MaxNumberOfBalloons(input);
        rez.Should().Be(output);
    }
}
