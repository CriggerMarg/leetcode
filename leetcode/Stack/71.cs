namespace leetcode.Stack;

/// <summary>
/// https://leetcode.com/problems/simplify-path/
/// </summary>
public class _71
{
	public string SimplifyPath(string path)
	{
		Stack<string> simple = new();
		string[] split = path.Split("/", StringSplitOptions.RemoveEmptyEntries);
		string delimiter = "/";
		foreach (var s in split)
		{
			switch (s)
			{
				case "..": simple.TryPop(out _); break;
				case ".": break; // do nothing
				default: simple.Push(delimiter + s); break;
			}
		}
		if (simple.Count == 0) return delimiter;
		return string.Join("", simple.Reverse());
	}
}
