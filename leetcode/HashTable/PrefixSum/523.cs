namespace leetcode.HashTable.PrefixSum;

/// <summary>
/// https://leetcode.com/problems/continuous-subarray-sum/
/// </summary>
public class _523
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        long[] prefix = new long[nums.Length];
        prefix[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = nums[i] + prefix[i - 1];
        }

        return false;
    }
}
