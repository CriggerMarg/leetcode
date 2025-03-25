namespace leetcode.SlidingWindow;
/// <summary>
/// https://leetcode.com/problems/minimum-difference-between-highest-and-lowest-of-k-scores/
/// </summary>
public class _1984
{
    public int MinimumDifference(int[] nums, int k)
    {
        if (k < 2) return 0;

		System.Array.Sort(nums);
        int right = k - 1;
        int diff = int.MaxValue;
        while (right < nums.Length)
        {
            int left = right - k + 1;
            int numLeft = nums[left];
            int numRight = nums[right];
            diff = Math.Min(diff, numRight - numLeft);
            right++;
        }

        return diff;
    }

}
