using FluentAssertions;
using leetcode.HashTable.PrefixSum;

namespace leetcode.tests.HashTable.PrefixSum;

public class _523Tests
{
    [Theory]
    [InlineData(new int[] { 23, 2, 4, 6, 7 }, 6, true)]
    [InlineData(new int[] { 23, 2, 4, 6, 7 }, 13, false)]
    public void TestCases(int[] nums, int k, bool expected)
    {
        var test = new _523();
        var rez = test.CheckSubarraySum(nums, k);
        rez.Should().Be(expected);
    }
}
