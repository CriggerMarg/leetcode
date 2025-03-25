namespace leetcode.HashTable;
/// <summary>
/// https://leetcode.com/problems/maximum-number-of-balloons/
/// </summary>
public class _1189
{
    public int MaxNumberOfBalloons(string text)
    {
        Dictionary<char, int> counts = [];
        foreach (var ch in text)
        {
            if (!counts.TryAdd(ch, 1)) counts[ch] += 1;
        }
        Dictionary<char, int> balloon = new()
        {
            { 'b', 1 },
            { 'a', 1 },
            { 'l', 2 },
            { 'o', 2 },
            { 'n', 1 }
        };
        bool canCount = true;
        int count = -1;
        while (canCount)
        {
            foreach (var kvp in balloon)
            {
                if (!counts.TryGetValue(kvp.Key, out int value) || value - kvp.Value < 0)
                {
                    canCount = false;
                    break;
                }
                counts[kvp.Key] -= kvp.Value;
                if (counts[kvp.Key] == 0) counts.Remove(kvp.Key);
            }
            count++;
        }
        return count;
    }
}
