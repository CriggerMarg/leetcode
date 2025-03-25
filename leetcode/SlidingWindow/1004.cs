namespace leetcode.SlidingWindow;
/// <summary>
/// https://leetcode.com/problems/max-consecutive-ones-iii/
/// </summary>
public class _1004
{
    public int LongestOnes(int[] nums, int k)
    {
        int zeroCount = 0;
        int left = 0;
        int right = 0;
        int max = 0;
        while (right < nums.Length)
        {
            var curr = nums[right];
            if (curr == 0) zeroCount++;

            while (zeroCount > k)
            {
                if (nums[left] == 0) zeroCount--;
                left++;

            }
            right++;
            max = Math.Max(max, right - left);
        }
        return max;
    }
}
