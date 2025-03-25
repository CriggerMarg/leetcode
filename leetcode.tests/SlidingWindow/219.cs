using FluentAssertions;
using leetcode.SlidingWindow;

namespace leetcode.tests.SlidingWindow;

public class _219_ContainsDuplicateIITests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, 3, true)]
    [InlineData(new int[] { 1, 0, 1, 1 }, 1, true)]
    [InlineData(new int[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    public void TestCases(int[] nums, int k, bool output)
    {
        var test = new _219();
        var rez = test.ContainsNearbyDuplicate(nums, k);
        rez.Should().Be(output);
    }
}
