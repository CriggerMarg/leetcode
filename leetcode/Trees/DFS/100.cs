namespace leetcode.Trees.DFS;
/// <summary>
/// https://leetcode.com/problems/same-tree/
/// </summary>
public class _100
{
    public bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        return Traverse(p, q);
    }

    private bool Traverse(TreeNode? left, TreeNode? right)
    {
        if (left is null && right is null) return true;

        var same = left?.val == right?.val;
        if (!same) return false;
        var leftSym = Traverse(left?.left, right?.left);
        var rightSym = Traverse(left?.right, right?.right);
        return leftSym && rightSym;
    }
}
