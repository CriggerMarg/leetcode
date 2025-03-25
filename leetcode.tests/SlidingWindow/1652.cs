using FluentAssertions;
using leetcode.SlidingWindow;

namespace leetcode.tests.SlidingWindow;
public class _1652_DefusetheBombTests
{
    [Theory]
    [InlineData(new int[] { 5, 7, 1, 4 }, 3, new int[] { 12, 10, 16, 13 })]
    [InlineData(new int[] { 2, 4, 9, 3 }, -2, new int[] { 12, 5, 6, 13 })]
    [InlineData(new int[] { 10, 5, 7, 7, 3, 2, 10, 3, 6, 9, 1, 6 }, -4, new int[] { 22, 26, 22, 28, 29, 22, 19, 22, 18, 21, 28, 19 })]
    [InlineData(new int[] { 1, 2, 3, 4 }, 0, new int[] { 0, 0, 0, 0 })]
    public void TestCases(int[] code, int k, int[] output)
    {
        var test = new _1652();
        var rez = test.Decrypt(code, k);
        rez.Should().Equal(output);
    }
}
