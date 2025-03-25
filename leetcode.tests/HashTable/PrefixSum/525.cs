using FluentAssertions;
using leetcode.HashTable.PrefixSum;

namespace leetcode.tests.HashTable.PrefixSum;

public class _525_tests
{
    [Theory]
    [InlineData(new int[] { 0, 1 }, 2)]
    [InlineData(new int[] { 0, 1, 0 }, 2)]
    [InlineData(new int[] { 0, 1, 0, 1 }, 4)]
    public void TestCases(int[] nums, int expected)
    {
        var test = new _525();
        var rez = test.FindMaxLength(nums);
        rez.Should().Be(expected);
    }
}
