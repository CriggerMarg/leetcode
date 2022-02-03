using code.structures;
using code.tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace code
{
    public static class Medium
    {
        /// <summary>
        /// 2. Add Two Numbers 
        /// https://leetcode.com/problems/add-two-numbers/
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int[] l = l1.Flatten();
            int[] r = l2.Flatten();

            var arr = l.Sum(r);
            Array.Reverse(arr);
            var list = arr.ToList();
            var current = new ListNode(list[0]);
            var head = current;
            for (var i = 1; i < list.Count; i++)
            {
                current = current.next = new ListNode(list[i]);
            }

            return head;
        }

        /// <summary>
        /// 3. Longest Substring Without Repeating Characters
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

        /// <summary>
        /// 7. Reverse Integer
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

            return int.TryParse(rr, out var rez) ? rez : 0;
        }

        /// <summary>
        /// 11. Container With Most Water
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
    }
}
