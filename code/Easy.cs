using System;
using System.Collections.Generic;

namespace code
{
    public static class Easy
    {
        /// <summary>
        /// https://leetcode.com/problems/defanging-an-ip-address/
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

        /// <summary>
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

        /// <summary>
        /// https://leetcode.com/problems/longest-common-prefix/
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static string LongestCommonPrefix(string[] strs)
        {
            string output = "";
            int minLength = -1;
            foreach (var item in strs)
            {
                if (minLength == -1) minLength = item.Length;
                if (item.Length < minLength) minLength = item.Length;
            }

            for (int i = 0; i < minLength; i++)
            {
                string currChar = "";
                foreach (var str in strs)
                {
                    if (currChar == "") currChar = str.Substring(i, 1);
                    if (currChar != str.Substring(i, 1)) return output;
                }
                output += currChar;
            }
            return output;
        }
    }
}
