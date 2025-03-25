namespace leetcode.SlidingWindow;
/// <summary>
/// https://leetcode.com/problems/contains-duplicate-ii/
/// </summary>
public class _219
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        int abs = k + 1;
        for (int left = 0; left < nums.Length - 1; left++)
        {
            for (int right = left + 1; right < nums.Length; right++)
            {
                if (nums[left] == nums[right])
                {
                    abs = Math.Min(abs, Math.Abs(left - right));
                }
            }
        }
        return abs <= k;
    }
}
