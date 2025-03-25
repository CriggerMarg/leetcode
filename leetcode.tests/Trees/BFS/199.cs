using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.BFS;

namespace leetcode.tests.Trees.BFS;
public class _199_Tests
{
    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                 [new int?[] { 1, 2, 3, null, 5, null, 4 },new List<int> { 1, 3, 4 }],
                 [new int?[] { 1, null, 3 },new List<int> { 1, 3}],
                 [new int?[] { },new List<int> {}],
                 [new int?[] { 1,2},new List<int> {1,2}],
            ];
    }
    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(int?[] left, List<int> expected)
    {
        var test = new _199();
        var p = TreeHelper.BuildTreeFromLevelOrder(left);
        var rez = test.RightSideView(p);
        rez.Should().BeEquivalentTo(expected);
    }
}
