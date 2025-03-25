using FluentAssertions;
using leetcode.Trees.DFS;

namespace leetcode.tests.Trees.DFS;

public class _111_Tests
{
    [Fact]
    public void TestCases()
    {
        var root = new TreeNode(2, null, new TreeNode(3, null, new TreeNode(4, null, new TreeNode(5, null, new TreeNode(6)))));
        var test = new _111();
        var rez = test.MinDepth(root);
        rez.Should().Be(5);
    }
}
