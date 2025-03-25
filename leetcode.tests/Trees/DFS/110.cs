using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.DFS;

namespace leetcode.tests.Trees.DFS;

public class _110_tests
{
    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                 [new int?[] { 3, 9, 20, null, null, 15, 7 },true],
                 [new int?[] { 1, 2, 2, 3, 3, null, null, 4, 4 },false],
                 [new int?[] {  },true],
            ];
    }

    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(int?[] left, bool expected)
    {
        var test = new _110();
        var p = TreeHelper.BuildTreeFromLevelOrder(left);
        var rez = test.IsBalanced(p);
        rez.Should().Be(expected);
    }
}
