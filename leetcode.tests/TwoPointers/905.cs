using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;
public class _905_SortArrayByParityTests
{
    [Theory]
    [InlineData(new int[] { 3, 1, 2, 4 }, new int[] { 4, 2, 1, 3 })]
    [InlineData(new int[] { 0, 1 }, new int[] { 0, 1 })]
    public void TestCases(int[] input, int[] output)
    {
        var test = new _905();
        var rez = test.SortArrayByParity(input);
        rez.Should().Equal(output);
    }
}
