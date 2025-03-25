namespace leetcode.Backtracking;

public class _797
{
	public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
	{
		IList<IList<int>> ans = [];


	//	Backtrack([], ans, graph);


		return ans;
	}


	void Backtrack(HashSet<int> curr, int i, IList<IList<int>> ans, int[][] graph)
	{
		if (i > graph.Length) return;


		for (int j = i; j < graph[j].Length; j++)
		{
			//if (curr.Add(graph[j]))
		}
	}
}
