namespace leetcode.BinarySearch;

public class _35
{
	public int SearchInsert(int[] nums, int target)
	{
		int left = 0;
		int right = nums.Length - 1;
		while (left <= right)
		{
			var mid = left + (right - left) / 2;
			if (nums[mid] == target) return mid;

			if (nums[mid] > target)
			{
				right = mid - 1;
			}
			else
			{
				left = mid + 1;
			}
		}
		return left;
	}
}
