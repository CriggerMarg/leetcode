using FluentAssertions;
using leetcode.Trees.DFS;

namespace leetcode.tests.Trees.DFS;
public class _1026_tests
{
    [Fact]
    public void TestCase1()
    {
        var root = new TreeNode(8, new TreeNode(3, new TreeNode(1), new TreeNode(6, new TreeNode(4), new TreeNode(7))), new TreeNode(10, null, new TreeNode(14, new TreeNode(13))));
        var test = new _1026();
        var rez = test.MaxAncestorDiff(root);
        rez.Should().Be(7);
    }

    [Fact]
    public void TestCase2()
    {
        var root = new TreeNode(1, null, new TreeNode(2, null, new TreeNode(0, null, new TreeNode(3))));
        var test = new _1026();
        var rez = test.MaxAncestorDiff(root);
        rez.Should().Be(3);
    }
}
