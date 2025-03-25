namespace leetcode.Trees.DFS;
public class _113
{
    private readonly IList<IList<int>> _l = [];

    public IList<IList<int>> PathSum(TreeNode? root, int targetSum)
    {
        Traverse(root, [], 0, targetSum);
        return _l;
    }

    private void Traverse(TreeNode? root, List<int> list, int currentSum, int targetSum)
    {
        if (root == null) return;
        if (root.left == null && root.right == null)
        {
            if (currentSum + root.val == targetSum)
            {
                list.Add(root.val);
                _l.Add(new List<int>(list));
                return;
            }
            return;
        }
        list.Add(root.val);
        currentSum += root.val;
        Traverse(root.left, new List<int>(list), currentSum, targetSum);
        Traverse(root.right, new List<int>(list), currentSum, targetSum);
    }

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
