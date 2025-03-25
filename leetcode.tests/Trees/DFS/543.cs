using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.DFS;

namespace leetcode.tests.Trees.DFS;
public class _543_Tests
{
    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                 [new int?[] { 1, 2, 3, 4, 5 }, 3],
                 [new int?[] { 1, 2 }, 1],
                 [new int?[] { 4, -7, -3, null, null, -9, -3, 9, -7, -4, null, 6, null, -6, -6, null, null, 0, 6, 5, null, 9, null, null, -1, -4, null, null, null, -2 }, 8],
            ];
    }
    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCase2(int?[] input, int expected)
    {
        var root = TreeHelper.BuildTreeFromLevelOrder(input);
        var test = new _543();
        var rez = test.DiameterOfBinaryTree(root);
        rez.Should().Be(expected);
    }
}
