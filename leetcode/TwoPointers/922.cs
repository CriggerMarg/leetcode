namespace leetcode.TwoPointers;
/// <summary>
/// https://leetcode.com/problems/sort-array-by-parity-ii/
/// </summary>
public class _922
{
    public int[] SortArrayByParityII(int[] nums)
    {
        if (nums.Length == 0) return nums;

        int left = 0;
        while (left < nums.Length)
        {
            while (left < nums.Length && (nums[left] & 0x1) == (left & 0x1)) left++;

            if (left < nums.Length - 1)
            {
                int even = nums[left] % 2;
                int right = left + 1;
                int next = nums[right];
                while (left < nums.Length && (next & 0x1) == even)
                {
                    right++;
                    next = nums[right];
                }
                int tmp = nums[right];
                nums[right] = nums[left];
                nums[left] = tmp;
            }
            left++;
        }
        return nums;
    }
}
