namespace leetcode.Trees.BFS;
public class _226
{

	public TreeNode? InvertTree(TreeNode? root)
	{
		if (root == null) return null;
		Queue<TreeNode> q = new();
		q.Enqueue(root);
		while (q.Count > 0)
		{
			TreeNode node = q.Dequeue();
			var tmp = node.left;
			node.right = node.left;
			node.left = tmp;
			if (node.left != null) q.Enqueue(node.left);
			if (node.right != null) q.Enqueue(node.right);
		}
		return root;
	}
}
