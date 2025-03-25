using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.DFS;

namespace leetcode.tests.Trees.DFS;
public class _113_tests
{
    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                 [new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 },22,new List<List<int>> { new() { 5, 4, 11, 2 }, new() { 5, 8, 4, 5 } }],
            ];
    }
    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(int?[] left, int sum, List<List<int>> expected)
    {
        var test = new _113();
        var p = TreeHelper.BuildTreeFromLevelOrder(left);
        var rez = test.PathSum(p, sum);
        rez.Should().BeEquivalentTo(expected);
    }
}
