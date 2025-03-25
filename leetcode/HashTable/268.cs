namespace leetcode.HashTable;

/// <summary>
/// https://leetcode.com/problems/missing-number/
/// </summary>
public class _268
{
    public int MissingNumber(int[] nums)
    {
        HashSet<int> allNums = new(Enumerable.Range(0, nums.Length + 1));
        for (int i = 0; i < nums.Length; i++)
        {
            allNums.Remove(nums[i]);
        }
        return allNums.First();
    }
}
