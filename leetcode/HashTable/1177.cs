namespace leetcode.HashTable;

public class _1177
{
	public IList<bool> CanMakePaliQueries(string s, int[][] queries)
	{
		IList<bool> ans = [];
		foreach (int[] q in queries)
		{
			HashSet<char> symbols = [];
			int replaceCount = q[2];
			for (int i = q[0]; i <= q[1]; i++)
			{
				if (symbols.Contains(s[i]))
				{
					// already have 1, remove it
					symbols.Remove(s[i]);
				}
				else { symbols.Add(s[i]); }
			}
			ans.Add(replaceCount >= symbols.Count / 2);
		}
		return ans;
	}
}
