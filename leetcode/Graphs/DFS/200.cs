namespace leetcode.Graphs.DFS;
public class _200
{
	bool[][] _seen;

	public int NumIslands(char[][] grid)
	{
		_seen = new bool[grid.Length][];
		for (int i = 0; i < grid.Length; i++)
		{
			_seen[i] = new bool[grid[i].Length];
		}
		int ans = 0;
		for (int row = 0; row < grid.Length; row++)
		{
			for (int col = 0; col < grid[row].Length; col++)
			{
				if (!_seen[row][col] && IsIsland(row, col, grid))
				{
					ans++;
					DFS(row, col, grid);
				}

			}
		}
		return ans;
	}
	private bool IsIsland(int row, int col, char[][] grid)
	{
		return grid[row][col] == '1';
	}


	private bool IsInGrid(int row, int col, char[][] grid)
	{
		return row >= 0 && row < grid.Length && col >= 0 && col < grid[row].Length;
	}

	private void DFS(int row, int col, char[][] grid)
	{
		int[][] directions = [
			[0,1],  // down
			[0,-1], // up
			[1,0],  // right
			[-1,0], // left
			];


		_seen[row][col] = true;

		foreach (var d in directions)
		{
			int nextRow = row + d[0];
			int nextCol = col + d[1];

			if (IsInGrid(nextRow, nextCol, grid) && !_seen[nextRow][nextCol] && IsIsland(nextRow, nextCol, grid))
			{
				DFS(nextRow, nextCol, grid);
			}
		}
	}
}
