namespace leetcode.tests.Helpers;
public static class TreeHelper
{
	public static TreeNode? BuildTreeFromLevelOrder(int?[] values)
	{
		if (values == null || values.Length == 0 || values[0] == null)
			return default;

		TreeNode root = new(values[0]!.Value);
		Queue<TreeNode> queue = new Queue<TreeNode>();
		queue.Enqueue(root);

		int i = 1;
		while (i < values.Length)
		{
			TreeNode current = queue.Dequeue();

			// Set the left child
			if (i < values.Length && values[i] != null)
			{
				current.left = new TreeNode(values[i]!.Value);
				queue.Enqueue(current.left);
			}
			i++;

			// Set the right child
			if (i < values.Length && values[i] != null)
			{
				current.right = new TreeNode(values[i]!.Value);
				queue.Enqueue(current.right);
			}
			i++;
		}

		return root;
	}
}