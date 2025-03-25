namespace leetcode.SlidingWindow;
/// <summary>
/// https://leetcode.com/problems/maximum-average-subarray-i/
/// </summary>
public class _643
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int curr = 0;
        for (int i = 0; i < k; i++)
        {
            curr += nums[i];
        }

        double ans = curr / (double)k;
        for (int i = k; i < nums.Length; i++)
        {
            curr += nums[i] - nums[i - k];
            var avg = curr / (double)k;
            ans = Math.Max(ans, avg);
        }

        return ans;
    }
}
