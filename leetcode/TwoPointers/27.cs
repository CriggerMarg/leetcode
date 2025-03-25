namespace leetcode.TwoPointers;

/// <summary>
/// https://leetcode.com/problems/remove-element/description/
/// </summary>
public class _27
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0) return 0;

        int left = 0;
        int right = nums.Length - 1;
        int k = nums.Length;
        while (left <= right)
        {
            while (left <= right && nums[right] == val)
            {
                k--;
                right--;
            };
            if (left <= right && nums[left] == val)
            {
                nums[left] = nums[right];
                right--;
                k--;
            }
            left++;
        }

        return k;
    }
}
