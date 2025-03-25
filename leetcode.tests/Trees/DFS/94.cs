using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.DFS;

namespace leetcode.tests.Trees.DFS;

public class _94_Tests
{
    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                 [new int?[] { 1, null, 2, 3 }, new List<int> { 1, 3, 2 }],
            ];
    }
    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(int?[] input, IList<int> expected)
    {
        var test = new _94();
        var root = TreeHelper.BuildTreeFromLevelOrder(input);
        var rez = test.InorderTraversal(root);
        rez.Should().BeEquivalentTo(expected);
    }

}
