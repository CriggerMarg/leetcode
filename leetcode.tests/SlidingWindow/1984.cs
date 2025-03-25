using FluentAssertions;
using leetcode.SlidingWindow;

namespace leetcode.tests.SlidingWindow;

public class _1984_Tests
{
    [Theory]
    [InlineData(new int[] { 90 }, 0, 0)]
    [InlineData(new int[] { 9, 4, 1, 7 }, 2, 2)]
    [InlineData(new int[] { 87063, 61094, 44530, 21297, 95857, 93551, 9918 }, 6, 74560)]
    public void TestCases(int[] nums, int k, int output)
    {
        var test = new _1984();
        var rez = test.MinimumDifference(nums, k);
        rez.Should().Be(output);
    }
}
