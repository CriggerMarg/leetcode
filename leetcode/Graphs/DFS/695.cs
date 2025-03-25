namespace leetcode.Graphs.DFS;
public class _695
{
	bool[][] _seen; // ты конечно уже забыл в чём разница между [,] и [][]. 
					// [,] работает для квадратов, x и y всегда равны в нём. 
					// [][] для так называемых jagged arrays, где количество строк не равно количеству колонок
	public int MaxAreaOfIsland(int[][] grid)
	{

		int ans = 0;

		_seen = new bool[grid.Length][];
		for (int i = 0; i < grid.Length; i++)
		{
			_seen[i] = new bool[grid[i].Length];
		}

		for (int row = 0; row < grid.Length; row++)
		{
			for (int col = 0; col < grid[row].Length; col++)
			{
				if (IsIsland(row, col, grid) && !_seen[row][col])
				{
					_seen[row][col] = true;
					int area = 1;
					Dfs(row, col, grid, ref area);
					ans = Math.Max(area, ans);
				}
			}
		}

		return ans;
	}


	private bool IsIsland(int row, int col, int[][] grid)
	{
		return grid[row][col] == 1;
	}

	private bool IsInBounds(int row, int col, int[][] grid)
	{
		return row >= 0 && row < grid.Length && col >= 0 && col < grid[row].Length;
	}

	private void Dfs(int row, int col, int[][] grid, ref int area)
	{
		int[][] directions = [[1, 0], // вправо
							[0,1], // вниз
							[-1,0], // влево
							[0,-1]// вверх
							];
		foreach (var direction in directions)
		{
			int nextRow = row + direction[0];
			int nextCol = col + direction[1];
			if (IsInBounds(nextRow, nextCol, grid) && IsIsland(nextRow, nextCol, grid) && !_seen[nextRow][nextCol])
			{
				_seen[nextRow][nextCol] = true;
				area++;
				Dfs(nextRow, nextCol, grid, ref area);
			}
		}
	}

}
