namespace leetcode.Graphs.DFS;
public class _323
{
	public int CountComponents(int n, int[][] edges)
	{
		var graph = new Dictionary<int, List<int>>();
		for (int i = 0; i < n; i++)
		{
			graph[i] = [];
		}
		for (int i = 0; i < edges.Length; i++)
		{
			var x = edges[i][0];
			var y = edges[i][1];
			graph[x].Add(y);
			graph[y].Add(x);
		}

		int ans = 0;
		bool[] seen = new bool[n];

		for (int j = 0; j < n; j++)
		{
			if (!seen[j])
			{
				ans++;
				dfs(graph, seen, j);
			}
		}
		void dfs(Dictionary<int, List<int>> graph, bool[] seen, int node)
		{
			foreach (var n in graph[node])
			{
				if (!seen[n])
				{
					seen[n] = true;
					dfs(graph, seen, n);
				}
			}
		}
		return ans;
	}
}
