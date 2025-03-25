namespace leetcode.Backtracking;

public class _78
{
	public IList<IList<int>> Subsets(int[] nums)
	{
		IList<IList<int>> ans = [];
		Backtrack(new HashSet<int>(), 0, ans, nums);
		return ans;
	}

	/*
	[1,2,3]

	[]
	[1]
	[1,2]
	[1,3]
	[1,2,3]
	
	
	1.
	i = 0
	ans [[]]
	curr [1]
		i = 1
		ans [[],[1]]
		curr [1,2]
			i = 2
			ans [[],[1],[1,2]]
			curr [1,2,3]
				i = 3
				ans [[],[1],[1,2],[1,2,3]]
				
	 */
	void Backtrack(ISet<int> curr, int i, IList<IList<int>> ans, int[] nums)
	{
		if (i > nums.Length)
		{
			return;
		}
		ans.Add([.. curr]);

		for (int j = i; j < nums.Length; j++)
		{
			int num = nums[j];
			if (curr.Add(num))
			{
				Backtrack(curr, j + 1, ans, nums);
				curr.Remove(num);
			}
		}
	}
}
