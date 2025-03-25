namespace leetcode.Graphs.DFS;
public class _2368
{
	Dictionary<int, List<int>> _graph = [];
	bool[]? _seen;

	int ans = 0;
	public int ReachableNodes(int n, int[][] edges, int[] restricted)
	{
		_seen = new bool[n];
		for (int i = 0; i < n; i++)
		{
			_graph.Add(i, []);
		}
		HashSet<int> strict = new(restricted);
		foreach (int[] edge in edges)
		{
			int x = edge[0];
			int y = edge[1];
			if (!strict.Contains(y) && !strict.Contains(x))
			{
				_graph[x].Add(y);
				_graph[y].Add(x);
			}
		}
		if (_graph.ContainsKey(0))
		{
			ans++;
			_seen[0] = true;
			Dfs(0, restricted);
		}
		return ans;
	}

	private void Dfs(int node, int[] restricted)
	{
		foreach (var n in _graph[node])
		{
			if (!_seen![n])
			{
				_seen[n] = true;
				ans++;

				Dfs(n, restricted);
			}
		}
	}
}
