namespace leetcode.Trees.BFS;

public class _102
{
	public IList<IList<int>> LevelOrder(TreeNode? root)
	{
		IList<IList<int>> levels = [];

		if (root == null) return levels;
		Queue<TreeNode> q = [];

		q.Enqueue(root);
		while (q.Count > 0)
		{
			int len = q.Count;
			List<int> curr = [];
			for (int i = 0; i < len; i++)
			{
				var node = q.Dequeue();
				curr.Add(node.val);
				if (node.left != null)
					q.Enqueue(node.left);
				if (node.right != null)
					q.Enqueue(node.right);
			}
			levels.Add(curr);

			/*
			[3,9,20,null,null,15,7]


			lvls [[3]]   q[9,20]
			lvls [[3], [9,20]]  q[15,7]

			 */
		}


		return levels;
	}
}
