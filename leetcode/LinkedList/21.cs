namespace leetcode.LinkedList;
public class _21
{
	public ListNode MergeTwoLists(ListNode list1, ListNode list2)
	{
		if (list1 == null && list2 == null) return null;
		if (list1 == null) return list2;
		if (list2 == null) return list1;
		ListNode head = null;
		if (list1.val < list2.val)
		{
			head = list1;
			list1 = list1.next;
		}
		else
		{
			head = list2;
			list2 = list2.next;
		}
		ListNode node = head;
		while (list1 != null || list2 != null)
		{
			if (list1 != null && list2 != null)
			{
				if (list1.val < list2.val)
				{
					node.next = list1;
					list1 = list1.next;
				}
				else
				{
					node.next = list2;
					list2 = list2.next;
				}
			}
			else if (list1 != null)
			{
				node.next = list1;
				list1 = list1.next;
			}
			else
			{
				node.next = list2;
				list2 = list2.next;
			}
			node = node.next;

		}
		return head;
	}
}
