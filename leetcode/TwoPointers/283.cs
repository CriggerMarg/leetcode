namespace leetcode.TwoPointers;
/// <summary>
/// https://leetcode.com/problems/move-zeroes/
/// </summary>
public class _283
{
    public void MoveZeroes(int[] nums)
    {
        int left = 0;
        while (left < nums.Length - 1)
        {
            if (nums[left] == 0)
            {
                int right = left + 1;
                while (right < nums.Length - 1 && nums[right] == 0)
                    right++;
                int tmp = nums[left];
                nums[left] = nums[right];
                nums[right] = tmp;
            }
            left++;
        }
    }
}
