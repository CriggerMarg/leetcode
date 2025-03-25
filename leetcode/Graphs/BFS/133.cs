
namespace leetcode.Graphs.BFS;
using Node = GraphNode;

public class _133
{
	public Node CloneGraph(Node node)
	{
		if (node == null) return null;

		Dictionary<Node, Node> visited = [];
		Queue<Node> q = [];

		q.Enqueue(node);
		visited[node] = new Node(node.val);

		while (q.Count > 0)
		{
			var n = q.Dequeue();
			foreach (var neighbor in n.neighbors)
			{
				if (!visited.TryGetValue(neighbor, out Node? value))
				{
					value = new Node(neighbor.val);
					visited[neighbor] = value;
					q.Enqueue(neighbor);
				}
				visited[n].neighbors.Add(value);
			}

		}
		return visited[node];
	}
}
