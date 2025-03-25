namespace leetcode.BinarySearch;

public class _153
{
	public int FindMin(int[] nums)
	{
		if (nums.Length == 1) return nums[0];
		int left = 0;
		int right = nums.Length - 1;
		int min = int.MaxValue;
		while (left <= right)
		{
			var mid = left + (right - left) / 2;
			min = Math.Min(nums[mid], min);
			if (nums[mid] > nums[mid + 1])
				return nums[mid + 1];
			if (nums[mid - 1] > nums[mid])
				return nums[mid];
			if (nums[mid] > nums[0])
			{
				left = mid + 1;
			}
			else
			{
				right = mid - 1;
			}
		}
		return min;
	}
}
