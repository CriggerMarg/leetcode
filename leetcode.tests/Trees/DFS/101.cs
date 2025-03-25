using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.DFS;

namespace leetcode.tests.Trees.DFS;
public class _101_tests
{
    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                 [new int?[] { 1, 2, 2, 3, 4, 4, 3 },true],
                 [new int?[] { 1, 2, 2, null, 3, null, 3 },false],
            ];
    }
    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(int?[] left, bool expected)
    {
        var test = new _101();
        var p = TreeHelper.BuildTreeFromLevelOrder(left);
        var rez = test.IsSymmetric(p);
        rez.Should().Be(expected);
    }
}
