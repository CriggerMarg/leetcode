namespace leetcode.Graphs.DFS;
public class _547
{
	Dictionary<int, List<int>> _graph = [];
	bool[]? _seen;
	public int FindCircleNum(int[][] isConnected)
	{
		int n = isConnected.Length;
		_seen = new bool[n];

		for (int x = 0; x < n; x++)
		{
			if (!_graph.ContainsKey(x)) _graph.Add(x, []);

			for (int y = x + 1; y < n; y++)
			{
				if (!_graph.ContainsKey(y)) _graph.Add(y, []);

				if (isConnected[x][y] == 1)
				{
					_graph[x].Add(y);
					_graph[y].Add(x);
				}
			}
		}


		int ans = 0;
		for (int i = 0; i < n; i++)
		{
			if (!_seen[i])
			{
				_seen[i] = true;
				ans++;
				Dfs(i);
			}
		}

		return ans;
	}

	private void Dfs(int node)
	{
		if (_seen == null) return;
		foreach (var n in _graph[node])
		{
			if (!_seen[n])
			{
				_seen[n] = true;
				Dfs(n);
			}
		}
	}
}
