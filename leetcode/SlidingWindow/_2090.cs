namespace leetcode.SlidingWindow;
/// <summary>
/// https://leetcode.com/problems/k-radius-subarray-averages/
/// </summary>
public class _2090
{
    public int[] GetAverages(int[] nums, int k)
    {
        if (nums.Length < k * 2 + 1)
        {
			System.Array.Fill(nums, -1);
            return nums;
        }

        long[] prefix = new long[nums.Length];
        prefix[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = nums[i] + prefix[i - 1];
        }
        for (int i = 0; i < k; i++) nums[i] = -1;
        for (int i = nums.Length - k; i < nums.Length; i++) nums[i] = -1;
        int divd = k * 2 + 1;
        for (int i = k; i < k + 1; i++)
        {
            long avg = prefix[i + k] / divd;
            nums[i] = (int)avg;
        }
        for (int i = k + 1; i < prefix.Length - k; i++)
        {
            long avg = (prefix[i + k] - prefix[i - k - 1]) / divd;
            nums[i] = (int)avg;
        }

        return nums;
    }
}
