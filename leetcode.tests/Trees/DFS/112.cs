using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.DFS;

namespace leetcode.tests.Trees.DFS;
public class _112_tests
{
    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                 [new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 },22,true],
                 [new int?[] { 1, 2, 3 },5,false],
                 [new int?[] {},0,false],
                 [new int?[] {1,2},1,false],
            ];
    }
    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(int?[] left, int sum, bool expected)
    {
        var test = new _112();
        var p = TreeHelper.BuildTreeFromLevelOrder(left);
        var rez = test.HasPathSum(p, sum);
        rez.Should().Be(expected);
    }
}
