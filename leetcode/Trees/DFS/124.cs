namespace leetcode.Trees.DFS;
public class _124
{
    private int _max = int.MinValue;
    public int MaxPathSum(TreeNode? root)
    {
        int max = Traverse(root);
        return Math.Max(_max, max);
    }

    private int Traverse(TreeNode? root)
    {
        if (root == null) return 0;
        int left = Math.Max(0, Traverse(root.left));
        int right = Math.Max(0, Traverse(root.right));
        _max = Math.Max(_max, left + right + root.val);
        return Math.Max(left, right) + root.val;
    }
}
