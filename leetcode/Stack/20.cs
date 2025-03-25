namespace leetcode.Stack;
public class _20
{
	private bool IsOpenBracket(char c)
	{
		return c is '(' or '[' or '{';
	}

	private bool IsOpenBracketFor(char open, char close)
	{
		if (open == '(' && close == ')') return true;
		if (open == '[' && close == ']') return true;
		if (open == '{' && close == '}') return true;
		return false;
	}

	public bool IsValid(string s)
	{
		Stack<char> st = new();
		for (int i = 0; i < s.Length; i++)
		{
			if (IsOpenBracket(s[i]))
			{
				st.Push(s[i]);
			}
			else
			{
				if (st.TryPeek(out var last))
				{
					if (IsOpenBracketFor(last, s[i]))
					{
						st.Pop();
					}
				}
			}
		}
		return st.Count == 0;
	}
}
