using System.Text;

namespace leetcode.Backtracking;

public class _17
{
	private Dictionary<char, string> _map = new()
	{
		['2'] = "abc",
		['3'] = "def",
		['4'] = "ghi",
		['5'] = "jkl",
		['6'] = "mno",
		['7'] = "pqrs",
		['8'] = "tuv",
		['9'] = "wxyz",
	};

	public IList<string> LetterCombinations(string digits)
	{
		if (string.IsNullOrEmpty(digits)) return [];

		List<string> ans = [];
		Backtrack(new StringBuilder(), 0, ans, digits);
		return ans;

	}


	void Backtrack(StringBuilder sb, int i, List<string> ans, string digits)
	{
		if (sb.Length == digits.Length)
		{
			ans.Add(sb.ToString());
			return;
		}
		var letters = _map[digits[i]];
		foreach (var ch in letters)
		{
			sb.Append(ch);
			Backtrack(sb, i + 1, ans, digits);
			sb.Remove(sb.Length - 1, 1);
		}
	}
}
