using System.Collections.Generic;

namespace code
{
    public static partial class Easy
    {
        /// <summary>
        /// 13. Roman to Integer
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
    }
}
