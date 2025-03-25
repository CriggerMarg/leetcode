namespace leetcode.Backtracking;

public class _46
{
	public IList<IList<int>> Permute(int[] nums)
	{
		/*
		[1,2,3]
		[1,3,2]
		[2,1,3]
		[2,3,1]
		
	 curr [] -> 1
		curr [1]  -> [1,2]
			curr [1,2] -> 3
				 curr [1,2,3] => ans[[1,2,3]]
			curr [1,3] -> 2
				 curr [1,3,2] => ans[[1,2,3],[1,3,2]]
	curr [] -> 2
		curr [2]  -> [2,1]
			curr [2,1] -> 3
				 curr [2,1,3] => ans[[1,2,3],[1,3,2], [2,1,3]]
			curr [2,3] -> 1
				 curr [2,3,1] => ans[[1,2,3],[1,3,2], [2,1,3], [2,3,1]]
	curr [] -> 3
		curr [3]  -> [3,1]
			curr [3,1] -> 2
				 curr [3,1,2] => ans[[1,2,3],[1,3,2], [2,1,3], [2,3,1],[3,1,2]]
			curr [3,2] -> 1
				 curr [3,2,1] => ans[[1,2,3],[1,3,2], [2,1,3], [2,3,1],[3,1,2],[3,2,1]]
	 */
		IList<IList<int>> ans = [];
		Backtrack(new HashSet<int>(), ans, nums);
		return ans;
	}

	void Backtrack(ISet<int> curr, IList<IList<int>> ans, int[] nums)
	{
		if (curr.Count == nums.Length)
		{
			ans.Add([.. curr]);
			return;
		}

		foreach (int num in nums)
		{
			if (curr.Add(num))
			{
				Backtrack(curr, ans, nums);
				curr.Remove(num);
			}
		}
	}



}

