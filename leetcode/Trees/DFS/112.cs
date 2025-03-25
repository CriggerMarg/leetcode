namespace leetcode.Trees.DFS;
/// <summary>
/// https://leetcode.com/problems/path-sum
/// </summary>
public class _112
{
    public bool HasPathSum(TreeNode? root, int targetSum)
    {
        if (root is null) return false;
        if (root.left is null && root.right == null) return targetSum == root.val;

        var leftSum = HasPathSum(root.left, targetSum - root.val);
        if (leftSum) return true;
        var rightSum = HasPathSum(root.right, targetSum - root.val);
        return rightSum;
    }
}
