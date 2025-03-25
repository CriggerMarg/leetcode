namespace leetcode.Trees.DFS;

/// <summary>
/// https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/
/// </summary>
public class _1026
{
    public int MaxAncestorDiff(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        return Diff(root, root.val, root.val);
    }

    private int Diff(TreeNode? node, int curMax, int curMin)
    {
        if (node == null)
        {
            return curMax - curMin;
        }
        curMax = Math.Max(curMax, node.val);
        curMin = Math.Min(curMin, node.val);
        int left = Diff(node.left, curMax, curMin);
        int right = Diff(node.right, curMax, curMin);
        return Math.Max(left, right);
    }
}
