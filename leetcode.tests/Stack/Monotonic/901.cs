using FluentAssertions;
using leetcode.Stack.Monotonic;

namespace leetcode.tests.Stack.Monotonic;
public class _901_Tests
{
    [Theory]
    //[InlineData(new int[] { 100, 80, 60, 70, 60, 75, 85 }, new int[] { 1, 1, 1, 2, 1, 4, 6 })]
    [InlineData(new int[] { 28, 14, 28, 35, 46, 53, 66, 80, 87, 88 }, new int[] { 1, 1, 3, 4, 5, 6, 7, 8, 9, 10 })]
    //[InlineData(new int[] { 31, 41, 60, 48, 59, 79, }, new int[] { 1, 2, 1, 2, 1, 4, 6 })]
    public void TestCases(int[] nums1, int[] expected)
    {
        var test = new _901.StockSpanner();
        for (int i = 0; i < nums1.Length; i++)
        {
            var rez = test.Next(nums1[i]);
            rez.Should().Be(expected[i]);
        }
    }
}
