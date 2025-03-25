namespace leetcode.LinkedList;
public class _445
{
	public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
		var l1Reversed = Reverse(l1);
		var l2Reversed = Reverse(l2);
		ListNode? node = null;
		int carry = 0;
		while (l1Reversed != null || l2Reversed != null || carry != 0)
		{
			int x = l1Reversed == null ? 0 : l1Reversed.val;
			int y = l2Reversed == null ? 0 : l2Reversed.val;
			int sum = x + y + carry;
			carry = sum / 10;
			node = new(sum % 10, node);
			if (l1Reversed != null) l1Reversed = l1Reversed.next;
			if (l2Reversed != null) l2Reversed = l2Reversed.next;
		}
		return node;
	}


	private ListNode Reverse(ListNode head)
	{
		ListNode prev = null;
		while (head != null)
		{
			var next = head.next;
			head.next = prev;
			prev = head;
			head = next;
		}
		return prev;
	}
}
