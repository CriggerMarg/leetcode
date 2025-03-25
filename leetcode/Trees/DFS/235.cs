namespace leetcode.Trees.DFS;

public class _235
{
	public TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode p, TreeNode q)
	{
		if (root == null) return root;

		int rootVal = root.val;

		int pVal = p.val;
		int qVal = q.val;

		if (pVal > rootVal && qVal > rootVal)
			return LowestCommonAncestor(root.right, p, q);

		if (pVal < rootVal && qVal < rootVal)
			return LowestCommonAncestor(root.left, p, q);

		// LCA I have found you
		return root;
	}


}
