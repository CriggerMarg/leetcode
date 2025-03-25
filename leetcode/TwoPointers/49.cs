namespace leetcode.TwoPointers;
public class _49
{
	public IList<IList<string>> GroupAnagrams(string[] strs)
	{
		Dictionary<string, IList<string>> dict = [];

		foreach (string s in strs)
		{
			var arr = s.ToCharArray();
			System.Array.Sort(arr);
			var str = new string(arr);
			if (dict.TryGetValue(str, out var list))
			{
				list.Add(s);
			}
			else
			{
				dict[str] = [s];
			}
		}
		return [.. dict.Values];
	}
}
