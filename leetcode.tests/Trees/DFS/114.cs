using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.DFS;

namespace leetcode.tests.Trees.DFS;
public class _114_Tests
{
    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                 [new int?[] { 1, 2, 5, 3, 4, null, 6 },new int?[] { 1, null, 2, null, 3, null, 4, null, 5, null, 6 }],
            ];
    }
    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(int?[] left, int?[] expected)
    {
        var test = new _114();
        var p = TreeHelper.BuildTreeFromLevelOrder(left);
        test.Flatten(p);
        var e = TreeHelper.BuildTreeFromLevelOrder(expected);
        p.Should().BeEquivalentTo(e);
    }
}
