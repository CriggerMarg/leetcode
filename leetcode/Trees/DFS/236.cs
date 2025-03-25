namespace leetcode.Trees.DFS;

public class _236
{
	public TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode p, TreeNode q)
	{
		return DFS(root, p, q).Item2;
	}

	private (bool, TreeNode?) DFS(TreeNode? root, TreeNode p, TreeNode q)
	{
		if (root is null) return (false, default);
		TreeNode? found = null;
		var (left, leftFound) = DFS(root.left, p, q);
		if (leftFound != null) return (true, leftFound);
		var (right, rightFound) = DFS(root.right, p, q);
		if (rightFound != null) return (true, rightFound);
		var isCurr = root == p || root == q;

		if (left && right || isCurr && left || isCurr && right)
		{
			found = root;
		}

		return (left || right || isCurr, found);
	}
}
