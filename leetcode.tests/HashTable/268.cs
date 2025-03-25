using FluentAssertions;
using leetcode.HashTable;

namespace leetcode.tests.HashTable;

public class _268_MissingNumberTests
{
    [Theory]
    [InlineData(new int[] { 3, 0, 1 }, 2)]
    [InlineData(new int[] { 0, 1 }, 2)]
    [InlineData(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    [InlineData(new int[] { 45, 35, 38, 13, 12, 23, 48, 15, 44, 21, 43, 26, 6, 37, 1, 19, 22, 3, 11, 32, 4, 16, 28, 49, 29, 36, 33, 8, 9, 39, 46, 17, 41, 7, 2, 5, 27, 20, 40, 34, 30, 25, 47, 0, 31, 42, 24, 10, 14 }, 18)]
    public void TestCases(int[] nums, int output)
    {
        var test = new _268();
        var rez = test.MissingNumber(nums);
        rez.Should().Be(output);
    }
}
