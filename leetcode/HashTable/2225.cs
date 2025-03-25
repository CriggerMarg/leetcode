namespace leetcode.HashTable;

/// <summary>
/// https://leetcode.com/problems/find-players-with-zero-or-one-losses/
/// </summary>
public class _2225
{
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        HashSet<int> winners = [];
        Dictionary<int, int> losers = [];

        foreach (var match in matches)
        {
            if (!losers.ContainsKey(match[0]))
                //  find these who won something and didn't lose anything
                winners.Add(match[0]);
            winners.Remove(match[1]);

            if (!losers.TryAdd(match[1], 1))
            {
                losers[match[1]] += 1;
            }
        }
        var w = winners.ToArray();
        System.Array.Sort(w);
        var l = losers.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
		System.Array.Sort(l);
        return
        [
            w.ToList(),
            l.ToList()
        ];
    }
}
