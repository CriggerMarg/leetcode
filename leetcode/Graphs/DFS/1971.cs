namespace leetcode.Graphs.DFS;
public class _1971
{
	bool[]? _seen;
	Dictionary<int, List<int>> _graph = [];

	public bool ValidPath(int n, int[][] edges, int source, int destination)
	{
		if (source == destination) return true;

		for (int i = 0; i < n; i++) _graph[i] = [];

		for (int i = 0; i < edges.Length; i++)
		{
			int u = edges[i][0];
			int v = edges[i][1];
			_graph[u].Add(v);
			_graph[v].Add(u);
		}
		_seen = new bool[n];
		_seen[source] = true;

		return Dfs(source, destination);
	}

	private bool Dfs(int source, int destination)
	{
		if (_seen == null) return false;
		foreach (var n in _graph[source])
		{
			if (n == destination) return true;
			if (!_seen[n])
			{
				_seen[n] = true;
				if (Dfs(n, destination)) return true;
			}
		}
		return false;
	}

}
