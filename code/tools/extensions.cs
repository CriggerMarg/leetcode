using code.structures;
using System;
using System.Collections.Generic;

namespace code.tools
{
    public static class extensions
    {
        public static int[] Flatten(this ListNode head)
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


       public static int[] Sum(this int[] left, int[] right)
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
    }
}
