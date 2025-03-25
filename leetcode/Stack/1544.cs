namespace leetcode.Stack;
/// <summary>
/// https://leetcode.com/problems/make-the-string-great/
/// </summary>
public class _1544
{
    public string MakeGood(string s)
    {
        Stack<char> st = new();
        foreach (var c in s)
        {
            if (st.TryPeek(out var curr) && (c ^ 32) == curr)
            {
                st.Pop();
            }
            else st.Push(c);
        }
        char[] arr = new char[st.Count];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            arr[i] = st.Pop();
        }
        return new string(arr);
    }
}
