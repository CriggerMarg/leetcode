using FluentAssertions;
using leetcode.Stack.Monotonic;

namespace leetcode.tests.Stack.Monotonic;

public class _496_Tests
{
    [Theory]
    [InlineData(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 }, new int[] { -1, 3, -1 })]
    public void TestCases(int[] nums1, int[] nums2, int[] expected)
    {
        var test = new _496();
        var rez = test.NextGreaterElement(nums1, nums2);
        rez.Should().BeEquivalentTo(expected);
    }
}
