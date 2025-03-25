using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;

public class _977_SortedSquaresTests
{
    [Theory]
    [InlineData(new int[] { -4, -1, 0, 3, 10 }, new int[] { 0, 1, 9, 16, 100 })]
    [InlineData(new int[] { -7, -3, 2, 3, 11 }, new int[] { 4, 9, 9, 49, 121 })]

    public void ShouldSort(int[] input, int[] output)
    {
        var r = new _977();
        var result = r.SortedSquares(input);
        output.Should().Equal(result);
    }
}
