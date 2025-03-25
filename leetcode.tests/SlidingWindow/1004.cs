using FluentAssertions;
using leetcode.SlidingWindow;

namespace leetcode.tests.SlidingWindow;
public class _1004_tests
{

    [Theory]
    [InlineData(new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2, 6)]
    [InlineData(new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3, 10)]
    public void TestCases(int[] nums, int k, int output)
    {
        var test = new _1004();
        var rez = test.LongestOnes(nums, k);
        rez.Should().Be(output);
    }
}
