using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.LinkedList;
public class _2
{
	public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
		ListNode dummy = new(0);
		int carry = 0;
		ListNode node = dummy;
		while (l1 != null || l2 != null || carry != 0)
		{
			int x = l1 == null ? 0 : l1.val;
			int y = l2 == null ? 0 : l2.val;
			int sum = x + y + carry;
			carry = sum / 10;
			node.next = new(sum % 10);
			node = node.next;

			if (l1 != null) l1 = l1.next;
			if (l2 != null) l2 = l2.next;
		}
		return dummy.next;
	}


}
