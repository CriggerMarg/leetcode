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

        /// <summary>
        /// https://leetcode.com/problems/roman-to-integer/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int RomanToInt(string s)
        {
            var valuesDict = new Dictionary<char, int>
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 }
            };
            int sum = 0, lastnum = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (valuesDict[s[i]] >= lastnum)
                {
                    sum += valuesDict[s[i]];
                }
                else
                {
                    sum -= valuesDict[s[i]];
                }
                lastnum = valuesDict[s[i]];
            }
            return sum;
        }

        /// <summary>
        /// https://leetcode.com/problems/palindrome-number/
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var s = x.ToString();
            var l = s.Length;
            for (int i = 0; i < l - 1; i++)
            for (int j = l - 1; j > 0; j--)
            {
                if (s[i] != s[j])
                {
                    return false;
                }

                i++;
            }

            return true;

        }
        /// <summary>
        /// https://leetcode.com/problems/reverse-integer/
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x)
        {
            var rev = x.ToString().ToCharArray();
            Array.Reverse(rev);
            var rr = new string(rev);
            if (rr.EndsWith("-"))
            {
                rr = rr.Remove(rr.Length - 1);
                rr = rr.Insert(0, "-");
            }

            if (int.TryParse(rr, out var rez))
            {
                return rez;
            }

            return 0;
        }
    }
}
