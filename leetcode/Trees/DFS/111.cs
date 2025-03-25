namespace leetcode.Trees.DFS;
/// <summary>
/// https://leetcode.com/problems/minimum-depth-of-binary-tree
/// </summary>
public class _111
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        if (root.left == null && root.right == null)
        {
            return 1;
        }
        if (root.left == null)
        {
            var r = MinDepth(root.right);
            return 1 + r;
        }
        if (root.right == null)
        {
            var l = MinDepth(root.left);
            return 1 + l;
        }
        var left = MinDepth(root.left);
        var right = MinDepth(root.right);
        return 1 + Math.Min(left, right);
    }
}
