namespace leetcode.HashTable;
/// <summary>
/// https://leetcode.com/problems/largest-unique-number
/// </summary>
public class _1133
{
    public int LargestUniqueNumber(int[] nums)
    {
        Dictionary<int, int> counts = [];
        int max = -1;
        foreach (var i in nums)
        {
            if (!counts.TryAdd(i, 1))
            {
                counts[i] += 1;
            }

        }
        foreach (var kvp in counts)
        {
            if (kvp.Value == 1)
            {
                max = Math.Max(max, kvp.Key);
            }
        }
        return max;
    }
}
