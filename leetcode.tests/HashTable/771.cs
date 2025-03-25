using FluentAssertions;
using leetcode.HashTable;

namespace leetcode.tests.HashTable;
public class _771_Tests
{
    [Theory]
    [InlineData("aA", "aAAbbbb", 3)]
    [InlineData("z", "ZZ", 0)]
    public void TestCases(string jewels, string stones, int expected)
    {
        var test = new _771();
        var rez = test.NumJewelsInStones(jewels, stones);
        rez.Should().Be(expected);
    }
}
