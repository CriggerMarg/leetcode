using FluentAssertions;
using leetcode.SlidingWindow;

namespace leetcode.tests.SlidingWindow;
public class _2269Tests
{
    [Theory]
    [InlineData(240, 2, 2)]
    [InlineData(430043, 2, 2)]
    public void TestCases(int num, int k, int output)
    {
        var test = new _2269();
        var rez = test.DivisorSubstrings(num, k);
        rez.Should().Be(output);
    }
}
