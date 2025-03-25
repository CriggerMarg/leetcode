namespace leetcode.HashTable;
public class _1
{
	/// <summary>
	/// https://leetcode.com/problems/two-sum/description/
	/// </summary>
	public int[] TwoSum(int[] nums, int target)
	{
		var pairs = new Dictionary<int, int>();

		for (int i = 0; i < nums.Length; i++)
		{
			var diff = target - nums[i];
			if (pairs.TryGetValue(diff, out int value))
			{
				return [value, i];
			}
			pairs.TryAdd(nums[i], i);
		}
		return [];
	}
}
