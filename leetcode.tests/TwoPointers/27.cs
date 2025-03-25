using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;

public class _27_RemoveElementTests
{
    [Theory]
    [InlineData(new int[] { 1 }, 1, 0)]
    [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
    [InlineData(new int[] { 4, 1, 2, 4, 4, 0, 0 }, 4, 4)]
    public void TestCases(int[] nums, int val, int k)
    {
        var test = new _27();
        var rez = test.RemoveElement(nums, val);
        rez.Should().Be(k);
        nums.Take(k).Should().NotContain(val);
    }
}
