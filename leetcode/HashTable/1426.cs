namespace leetcode.HashTable;
/// <summary>
/// https://leetcode.com/problems/counting-elements/description/
/// </summary>
public class _1426
{
    public int CountElements(int[] arr)
    {
        HashSet<int> numbers = [];
        foreach (int i in arr)
        {
            numbers.Add(i);
        }
        int count = 0;
        foreach (int i in arr)
        {
            if (numbers.Contains(i + 1)) count++;
        }

        return count;
    }
}
