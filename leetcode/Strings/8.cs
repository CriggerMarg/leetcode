namespace leetcode.Strings;
public class _8
{
	public int MyAtoi(string s)
	{
		int i = 0;
		int sign = 1;
		while (i < s.Length && s[i] == ' ') i++;
		if (i < s.Length && s[i] == '-')
		{
			sign = -1;
			i++;
		}
		else if (i < s.Length && s[i] == '+') i++;
		while (i < s.Length && s[i] == '0') i++;

		int result = 0;
		while (i < s.Length && char.IsDigit(s[i]))
		{
			if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && s[i] - '0' > int.MaxValue % 10))
			{
				return sign == 1 ? int.MaxValue : int.MinValue;
			}

			result = result * 10 + (s[i++] - '0');
		}

		return sign * result;
	}
}
