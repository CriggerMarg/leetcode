using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.DFS;

namespace leetcode.tests.Trees.DFS;
public class _124_tests
{
    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                 [new int?[] { -2,-1},-1],
                 [new int?[] { -2,1},1],
                 [new int?[] { 1},1],
                 [new int?[] { 2,-1},2],
                 [new int?[] { -3 },-3],
                 [new int?[] { 1, 2, 3 },6],
                 [new int?[] { -10, 9, 20, null, null, 15, 7 },42],
            ];
    }
    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(int?[] left, int expected)
    {
        var test = new _124();
        var p = TreeHelper.BuildTreeFromLevelOrder(left);
        var rez = test.MaxPathSum(p);
        rez.Should().Be(expected);
    }
}
