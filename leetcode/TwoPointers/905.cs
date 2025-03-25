namespace leetcode.TwoPointers;
public class _905
{
	/// <summary>
	/// https://leetcode.com/problems/sort-array-by-parity/description/
	/// </summary>
	public int[] SortArrayByParity(int[] nums)
    {
        if (nums.Length == 0) return nums;

        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            while (left < right && nums[left] % 2 == 0) left++;
            while (left < right && nums[right] % 2 == 1) right--;
            // swap
            int tmp = nums[right];
            nums[right] = nums[left];
            nums[left] = tmp;
        }
        return nums;
    }
}
