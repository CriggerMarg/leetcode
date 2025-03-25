namespace leetcode.TwoPointers;
public class _186
{
	public void ReverseWords(char[] s)
	{
		int left = 0;
		int right = s.Length - 1;

		Reverse(s, left, right);
		int start = 0;
		int end = 0;
		while (end < s.Length)
		{
			while (end < s.Length && char.IsLetterOrDigit(s[end])) end++;

			Reverse(s, start, end - 1);
			while (end < s.Length && char.IsWhiteSpace(s[end])) end++;
			start = end;
		}
	}

	private void Reverse(char[] s, int left, int right)
	{
		while (left < right)
		{
			var tmp = s[left];
			s[left] = s[right];
			s[right] = tmp;
			left++;
			right--;
		}
	}
}
