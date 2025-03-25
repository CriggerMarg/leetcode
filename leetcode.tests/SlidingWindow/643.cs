using FluentAssertions;
using leetcode.SlidingWindow;

namespace leetcode.tests.SlidingWindow;
public class _643_MaximumAverageSubarrayITests
{

    [Theory]
    [InlineData(new int[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75000)]
    [InlineData(new int[] { 5 }, 1, 5.0000)]
    public void TestCases(int[] nums, int k, double output)
    {
        var test = new _643();
        var rez = test.FindMaxAverage(nums, k);
        rez.Should().BeApproximately(output, 0.00001);
    }
}
