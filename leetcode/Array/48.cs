﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array;
public class _48
{
	public void Rotate(int[][] matrix)
	{
		int n = matrix.Length;
		for (int i = 0; i < (n + 1) / 2; i++)
		{
			for (int j = 0; j < n / 2; j++)
			{
				int temp = matrix[n - 1 - j][i];
				matrix[n - 1 - j][i] = matrix[n - 1 - i][n - j - 1];
				matrix[n - 1 - i][n - j - 1] = matrix[j][n - 1 - i];
				matrix[j][n - 1 - i] = matrix[i][j];
				matrix[i][j] = temp;
			}
		}
	}

}
