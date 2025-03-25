namespace leetcode.Trees.BFS;

/// <summary>
/// https://leetcode.com/problems/deepest-leaves-sum/
/// </summary>
public class _1302
{
	public int DeepestLeavesSum(TreeNode? root)
	{
		int sum = 0;
		if (root == null) return sum;
		Queue<TreeNode> q = new();
		q.Enqueue(root);
		while (q.Count > 0)
		{
			sum = 0;
			int len = q.Count;
			for (int i = 0; i < len; i++)
			{
				TreeNode node = q.Dequeue();
				sum += node.val;
				if (node.left != null) q.Enqueue(node.left);
				if (node.right != null) q.Enqueue(node.right);

			}
		}
		return sum;
	}
}
