using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;
public class _922_SortArrayByParityIITests
{
    [Theory]
    [InlineData(new int[] { 4, 2, 5, 7 }, new int[] { 4, 5, 2, 7 })]
    [InlineData(new int[] { 2, 3 }, new int[] { 2, 3 })]
    [InlineData(new int[] { 4, 1, 2, 1 }, new int[] { 4, 1, 2, 1 })]
    public void TestCases(int[] input, int[] output)
    {
        var test = new _922();
        var rez = test.SortArrayByParityII(input);
        rez.Should().Equal(output);
    }
}
