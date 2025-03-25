using FluentAssertions;
using leetcode.HashTable;

namespace leetcode.tests.HashTable;

public class _1_TwoSumTests
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11, new int[] { 5, 11 })]
    public void TestCases(int[] nums, int target, int[] output)
    {
        var test = new _1();
        var rez = test.TwoSum(nums, target);
        rez.Should().Equal(output);
    }
}
