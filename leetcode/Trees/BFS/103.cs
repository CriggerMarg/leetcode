namespace leetcode.Trees.BFS;
public class _103
{
	public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
	{
		if (root == null) return [];
		Queue<TreeNode> q = new();
		q.Enqueue(root);
		bool zig = false;

		List<IList<int>> ret = [];
		while (q.Count > 0)
		{
			zig = !zig;
			int len = q.Count;
			int[] arr = new int[len];

			for (int i = 0; i < len; i++)
			{
				TreeNode node = q.Dequeue();
				int index = zig ? i : len - i - 1;
				arr[index] = node.val;
				if (node.left != null) q.Enqueue(node.left);
				if (node.right != null) q.Enqueue(node.right);

			}
			ret.Add([.. arr]);
		}
		return ret;
	}
}
