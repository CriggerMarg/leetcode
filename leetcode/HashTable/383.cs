namespace leetcode.HashTable;
/// <summary>
/// https://leetcode.com/problems/ransom-note/
/// </summary>
public class _383
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> mag = [];
        foreach (char c in magazine)
        {
            mag[c] = mag.GetValueOrDefault(c, 0) + 1;
        }
        foreach (var c in ransomNote)
        {
            if (!mag.TryGetValue(c, out var count))
            {
                return false;
            }
            if (count <= 0) return false;
            mag[c] = --count;
        }
        return true;
    }
}
