namespace leetcode.BinarySearch;

public class _74
{
	public bool SearchMatrix(int[][] matrix, int target)
	{
		int left = 0;
		int rowLen = matrix[0].Length;
		int right = matrix.Length * rowLen;

		/*
		
		right = 4 * 3 = 12
		mid = 6
		2 
		row = 1
		2
		*/
		while (left <= right)
		{
			var mid = left + (right - left) / 2;

			int col = mid;
			int row = 0;
			while (col >= rowLen)
			{
				col -= rowLen;
				row++;
			}
			if (row < matrix.Length && matrix[row][col] == target) return true;
			if (row < matrix.Length && matrix[row][col] < target)
			{
				left = mid + 1;
			}
			else
			{
				right = mid - 1;
			}
		}
		return false;
	}
}
