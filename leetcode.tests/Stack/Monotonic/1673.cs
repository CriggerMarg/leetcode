using FluentAssertions;
using leetcode.Stack.Monotonic;

namespace leetcode.tests.Stack.Monotonic;
public class _1673_Tests
{
    [Theory]
    [InlineData(new int[] { 3, 5, 2, 6 }, 2, new int[] { 2, 6 })]
    [InlineData(new int[] { 2, 4, 3, 3, 5, 4, 9, 6 }, 4, new int[] { 2, 3, 3, 4 })]
    [InlineData(new int[] { 71, 18, 52, 29, 55, 73, 24, 42, 66, 8, 80, 2 }, 3, new int[] { 8, 80, 2 })]
    [InlineData(new int[] { 84, 10, 71, 23, 66, 61, 62, 64, 34, 41, 80, 25, 91, 43, 4, 75, 65, 13, 37, 41, 46, 90, 55, 8, 85, 61, 95, 71 }, 24, new int[] { 10, 23, 61, 62, 34, 41, 80, 25, 91, 43, 4, 75, 65, 13, 37, 41, 46, 90, 55, 8, 85, 61, 95, 71 })]
    public void TestCases(int[] nums, int k, int[] expected)
    {
        var test = new _1673();
        var rez = test.MostCompetitive(nums, k);
        rez.Should().Equal(expected);
    }

}
