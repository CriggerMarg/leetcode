using FluentAssertions;
using leetcode.HashTable;

namespace leetcode.tests.HashTable;
public class _1133Tests
{
    [Theory]
    [InlineData(new int[] { 5, 7, 3, 9, 4, 9, 8, 3, 1 }, 8)]
    [InlineData(new int[] { 9, 9, 8, 8 }, -1)]
    public void TestCases(int[] nums, int output)
    {
        var test = new _1133();
        var rez = test.LargestUniqueNumber(nums);
        rez.Should().Be(output);
    }
}
