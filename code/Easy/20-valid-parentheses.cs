using System.Collections.Generic;

namespace code
{
    public static partial class Easy
    {
        /// <summary>
        /// 20. Valid Parentheses
        /// https://leetcode.com/problems/valid-parentheses/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValid(string s)
        {
            var map = new Dictionary<char, char>();
            map.Add(')', '(');
            map.Add('}', '{');
            map.Add(']', '[');

            if (string.IsNullOrEmpty(s))
            {
                return true;
            }
            if (s.Length % 2 != 0)
            {
                return false;
            }
            var stack = new Stack<char>();
            var lent = s.Length;
            for (int i = 0; i < lent; i++)
            {
                var c = s[i];
                if (map.ContainsKey(c))
                {
                    var topel = stack.Count == 0 ? '#' : stack.Pop();
                    if (topel != map[c])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }

            }

            return stack.Count == 0;
        }
    }
}
