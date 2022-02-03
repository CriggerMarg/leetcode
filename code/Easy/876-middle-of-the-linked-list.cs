using code.structures;
using System.Collections.Generic;

namespace code
{
    public static partial class Easy
    {
        /// <summary>
        /// 876. Middle of the Linked List
        /// https://leetcode.com/problems/middle-of-the-linked-list/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode MiddleNode(ListNode head)
        {
            if (head.next == null)
            {
                return head;
            }

            if (head.next.next == null)
            {
                return head.next;
            }
            var list = new List<ListNode>();
            var current = head;
            while (current.next != null)
            {
                list.Add(current);
                current = current.next;
            }

            var length = list.Count;
            if (length % 2 != 0)
            {
                return list[length / 2 + 1];
            }
            return list[length / 2];
        }
    }
}
