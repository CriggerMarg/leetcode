namespace leetcode.Trees.DFS;
/// <summary>
/// https://leetcode.com/problems/diameter-of-binary-tree/
/// </summary>
public class _543
{
    public int DiameterOfBinaryTree(TreeNode root)
    {
        if (root == null) return 0;

        int left = MaxLength(root);
        return _d;
    }
    private int _d;
    private int MaxLength(TreeNode? node)
    {
        if (node == null) return 0;
        var left = MaxLength(node.left);
        var right = MaxLength(node.right);
        _d = Math.Max(_d, left + right);
        return Math.Max(left, right) + 1;
    }
}
