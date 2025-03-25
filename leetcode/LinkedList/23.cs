namespace leetcode.LinkedList;
public class _23
{
	public ListNode MergeKLists(ListNode[] lists)
	{
		lists = lists.Where(x => x != null).ToArray();
		if (lists.Length == 0) return default;
		if (lists.Length == 1) return lists[0];
		ListNode head = lists[0];
		ListNode min = lists[0];
		int idx = 0;
		for (int i = 0; i < lists.Length; i++)
		{
			ListNode n = lists[i];
			if (n.val < min.val)
			{
				min = n;
				idx = i;
			}
		}
		head = min;
		lists[idx] = lists[idx].next;
		ListNode node = head;
		List<ListNode> list = new(lists.Where(x => x != null));
		while (list.Count > 0)
		{
			ListNode smallest = list[0];
			idx = 0;
			for (int i = 1; i < list.Count; i++)
			{
				if (list[i].val < smallest.val)
				{
					smallest = list[i];
					idx = i;
				}
			}
			node.next = smallest;
			node = smallest;
			list[idx] = smallest.next;
			list = list.Where(x => x != null).ToList();
		}

		return head;
	}
}
