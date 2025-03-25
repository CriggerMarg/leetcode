using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;
public class _88_MergeSortedArrayTests
{
    [Theory]
    [InlineData(new int[] { 1, 6, 9, 0, 0, 0, 0 }, 3, new int[] { 2, 4, 6, 8 }, 4, new int[] { 1, 2, 4, 6, 6, 8, 9 })]
    [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
    [InlineData(new int[] { 1 }, 1, new int[0], 0, new int[] { 1 })]
    [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
    [InlineData(new int[] { 2, 0 }, 1, new int[] { 1 }, 1, new int[] { 1, 2 })]
    public void TestCases(int[] nums1, int m, int[] nums2, int n, int[] result)
    {
        var test = new _88();
        test.Merge(nums1, m, nums2, n);
        nums1.Should().Equal(result);
    }
}
