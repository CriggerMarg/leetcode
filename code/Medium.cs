using System;
using System.Collections.Generic;
using System.Linq;
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

        #region MyRegion

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }

            public override bool Equals(object? obj)
            {
                var other = obj as ListNode;
                if (other == null)
                {
                    return false;
                }

                if (next != null)
                {
                    return other.val == val && next.Equals(other.next);
                }

                return other.val == val;
            }
        }

        private static int[] FlattenLinkedList(ListNode head)
        {
            if (head.next == null)
            {
                return new[]
                {
                    head.val
                };
            }


            var list = new Stack<ListNode>();
            var current = head;

            do
            {
                list.Push(current);
                current = current.next;
            } while (current != null);


            var rez = new int[list.Count];
            int r = 0;
            while (list.TryPop(out var node))
            {
                rez[r] = node.val;
                r++;
            }

            return rez;
        }

        static int[] sumArrays(int[] left, int[] right)
        {
            var curr = left;
            var other = right;
            if (right.Length < left.Length)
            {
                curr = right;
                other = left;
            }

            var newCurr = new int[other.Length];
            Array.Copy(curr, 0, newCurr, other.Length - curr.Length, curr.Length);
            bool addone = false;
            for (int i = newCurr.Length - 1; i > -1; i--)
            {
                var val = other[i] + newCurr[i];
                if (addone)
                {
                    val++;
                    addone = false;
                }
                if (val >= 10)
                {
                    addone = true;
                    val -= 10;
                }
                other[i] = val;
            }


            if (addone)
            {
                var ret = new int[other.Length + 1];
                Array.Copy(other, 0, ret, 1, other.Length);
                ret[0] = 1;
                return ret;
            }
            return other;
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var l = FlattenLinkedList(l1);
            var r = FlattenLinkedList(l2);

            var arr = sumArrays(l, r);
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

        #endregion
    }
}
