using FluentAssertions;
using leetcode.HashTable;

namespace leetcode.tests.HashTable;
public class _1426_CountingElementsTests
{


    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 2)]
    [InlineData(new int[] { 1, 1, 3, 3, 5, 5, 7, 7 }, 0)]
    public void TestCases(int[] arr, int output)
    {
        var test = new _1426();
        var rez = test.CountElements(arr);
        rez.Should().Be(output);
    }
}
