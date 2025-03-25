namespace leetcode.Graphs.BFS;

public class _1926
{


	public int NearestExit(char[][] maze, int[] entrance)
	{
		bool[][] seen = new bool[maze.Length][];
		for (int i = 0; i < maze.Length; i++)
		{
			seen[i] = new bool[maze[i].Length];
		}
		Queue<(int row, int col, int steps)> q = new();
		q.Enqueue((entrance[0], entrance[1], 0));
		seen[entrance[0]][entrance[1]] = true;
		int m = maze.Length;
		int n = maze[0].Length;


		int[][] directions =
		[
			[0,1], // down
			[1,0], // right
			[-1,0], // left
			[0,-1]  // up
		];
		while (q.Count > 0)
		{
			var (row, col, steps) = q.Dequeue();
			if (IsBorder(row, col, maze) && (row != entrance[0] || col != entrance[1]))
			{
				return steps;
			}
			foreach (var d in directions)
			{
				int nextRow = row + d[0];
				int nextCol = col + d[1];

				if (IsInGrid(nextRow, nextCol, maze) && !seen[nextRow][nextCol] && IsPath(nextRow, nextCol, maze))
				{
					seen[nextRow][nextCol] = true;
					q.Enqueue((nextRow, nextCol, steps + 1));
				}
			}
		}
		return -1;
	}
	private bool IsBorder(int row, int col, char[][] maze)
	{
		return row == 0 || row == maze.Length - 1 || col == 0 || col == maze[row].Length - 1;
	}
	private bool IsInGrid(int row, int col, char[][] maze)
	{
		return row >= 0 && col >= 0 && row < maze.Length && col < maze[row].Length;
	}

	private bool IsPath(int row, int col, char[][] maze)
	{
		return maze[row][col] == '.';
	}


}
