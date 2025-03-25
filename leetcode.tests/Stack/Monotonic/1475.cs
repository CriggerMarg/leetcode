using FluentAssertions;
using leetcode.Stack.Monotonic;

namespace leetcode.tests.Stack.Monotonic;
public class _1475_Tests
{
    [Theory]
    [InlineData(new int[] { 8, 4, 6, 2, 3 }, new int[] { 4, 2, 4, 2, 3 })]
    public void TestCases(int[] nums1, int[] expected)
    {
        var test = new _1475();
        var rez = test.FinalPrices(nums1);
        rez.Should().BeEquivalentTo(expected);
    }
}
