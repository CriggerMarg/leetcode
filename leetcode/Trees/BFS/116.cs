namespace leetcode.Trees.BFS;

public class _116
{
	public Node? Connect(Node? root)
	{
		if (root == null) return null;

		Queue<Node> q = [];
		q.Enqueue(root);

		while (q.Count > 0)
		{

			int len = q.Count;

			for (int i = 0; i < len; i++)
			{
				var node = q.Dequeue();
				if (i < len - 1)
				{
					node.next = q.Peek();
				}

				if (node.left != null) q.Enqueue(node.left);
				if (node.right != null) q.Enqueue(node.right);
			}
		}

		return root;
	}
}
