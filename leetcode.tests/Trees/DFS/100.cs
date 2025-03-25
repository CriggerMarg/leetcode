using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.DFS;

namespace leetcode.tests.Trees.DFS;
public class _100_tests
{
    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                 [new int?[] { 1,  2, 3 }, new int?[] { 1,  2, 3 },true],
                 [new int?[] { 1,  2 }, new int?[] { 1, null, 2 }, false],
                 [new int?[] { 10, 5, 15 }, new int?[] { 10, 5, null, null, 15 }, false],
            ];
    }
    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(int?[] left, int?[] right, bool expected)
    {
        var test = new _100();
        var p = TreeHelper.BuildTreeFromLevelOrder(left);
        var q = TreeHelper.BuildTreeFromLevelOrder(right);
        var rez = test.IsSameTree(p, q);
        rez.Should().Be(expected);
    }
}
