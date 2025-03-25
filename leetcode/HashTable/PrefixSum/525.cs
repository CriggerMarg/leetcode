namespace leetcode.HashTable.PrefixSum;

/// <summary>
/// https://leetcode.com/problems/contiguous-array/
/// </summary>
public class _525
{
    public int FindMaxLength(int[] nums)
    {
        Dictionary<int, int> map = [];
        map[0] = -1;
        int maxlen = 0, count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int curr = nums[i] == 1 ? 1 : -1;
            count += curr;
            if (map.TryGetValue(count, out int value))
            {
                int a = i - value;
                maxlen = Math.Max(maxlen, a);
            }
            else
            {
                map[count] = i;
            }
        }
        return maxlen;
    }
}
