using code.structures;
using code.tools;
using System;
using System.Linq;

namespace code
{
    public static partial class Medium
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
    }
}
