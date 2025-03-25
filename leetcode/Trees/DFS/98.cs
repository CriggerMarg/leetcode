namespace leetcode.Trees.DFS;

public class _98
{
	public bool IsValidBST(TreeNode? root)
	{
		if (root is null) return true;

		return DFS(root, null, null);
	}


	private bool DFS(TreeNode? root, int? low, int? high)
	{
		if (root is null) return true;

		if (low.HasValue && root.val <= low.Value || high.HasValue && root.val >= high.Value)
			return false;


		return DFS(root.left, low, root.val) && DFS(root.right, root.val, high);
	}
}
