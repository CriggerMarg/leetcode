using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    public static class Medium
    {
        /// <summary>
        /// https://leetcode.com/problems/container-with-most-water/
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxArea(int[] height)
        {
            int maxarea = 0, l = 0, r = height.Length - 1;
            while (l < r)
            {
                maxarea = Math.Max(maxarea, Math.Min(height[l], height[r]) * (r - l));
                if (height[l] < height[r])
                    l++;
                else
                    r--;
            }
            return maxarea;
        }

        /// <summary>
        /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {

            if (s == null || string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int start = 0;

            var arr = new int[128];
            int index;
            int max = 0;
            int count = 0;
            var l = s.Length;
            for (int end = 0; end < l;)
            {
                index = s[end];
                if (arr[index] == 0)
                {
                    arr[index]++;
                    count++;
                    end++;
                }
                else
                {
                    arr[s[start++]]--;
                    count--;
                }

                if (count > max)
                {
                    max = count;
                }
            }

            return max;
        }
	}
}
