using System.Text;

namespace leetcode.TwoPointers;
public class _151
{
	public string ReverseWords(string s)
	{
		// remove leading and trailing spaces
		s = s.Trim();
		// split by spaces and reverse
		string[] words = s.Split(new char[] { ' ' },
			StringSplitOptions.RemoveEmptyEntries);
		System.Array.Reverse(words);
		// join the words with a space
		return String.Join(" ", words);
	}
}
