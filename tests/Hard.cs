using Xunit;
using LeetHard = code.Hard;

namespace tests
{
    public class Hard
    {
        [Theory(DisplayName = "4. Median of Two Sorted Arrays")]
        [InlineData(new int[0] , new[] { 1 }, 1)]
        [InlineData(new[] { 3 }, new[] { -2, -1 }, -1)]
        [InlineData(new[] { 1, 3, }, new[] { 2 }, 2.0)]
        [InlineData(new[] { 1, 2, }, new[] { 3, 4 }, 2.5)]
        public void FindMedianSortedArrays(int[] left, int[] right, double expected)
        {
            Assert.Equal(expected, LeetHard.FindMedianSortedArrays(left, right));
        }
    }
}