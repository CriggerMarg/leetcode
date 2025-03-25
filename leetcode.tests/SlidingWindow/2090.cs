using FluentAssertions;
using leetcode.SlidingWindow;

namespace leetcode.tests.SlidingWindow;

public class _2090_Tests
{
    [Theory]
    [InlineData(new int[] { 7, 4, 3, 9, 1, 8, 5, 2, 6 }, 3, new int[] { -1, -1, -1, 5, 4, 4, -1, -1, -1 })]
    [InlineData(new int[] { 100000 }, 0, new int[] { 100000 })]
    [InlineData(new int[] { 8 }, 100000, new int[] { -1 })]
    [InlineData(new int[] { 3, 3 }, 3, new int[] { -1, -1 })]
    public void TestCases(int[] nums, int k, int[] output)
    {
        var test = new _2090();
        var r = test.GetAverages(nums, k);
        r.Should().Equal(output);
    }
}
