namespace leetcode.HashTable;
/// <summary>
/// https://leetcode.com/problems/jewels-and-stones/
/// </summary>
public class _771
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        Dictionary<char, int> counts = [];
        int count = 0;
        foreach (char c in stones)
        {
            counts[c] = counts.GetValueOrDefault(c, 0) + 1;
        }
        foreach (var c in jewels)
        {
            if (counts.TryGetValue(c, out var jewelsCount))
            {
                count += jewelsCount;
            }
        }
        return count;
    }
}
