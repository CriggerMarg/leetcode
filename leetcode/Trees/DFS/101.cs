namespace leetcode.Trees.DFS;
/// <summary>
/// https://leetcode.com/problems/symmetric-tree
/// </summary>
public class _101
{
    public bool IsSymmetric(TreeNode? root)
    {
        if (root == null) return true;
        return Traverse(root.left, root.right);
    }

    private bool Traverse(TreeNode? left, TreeNode? right)
    {
        if (left is null && right is null) return true;
        var sym = left?.val == right?.val;
        var leftSym = Traverse(left?.left, right?.right);
        var rightSym = Traverse(right?.left, left?.right);
        return sym && leftSym && rightSym;
    }
}
