namespace leetcode.LinkedList;

/// <summary>
/// https://leetcode.com/problems/remove-nth-node-from-end-of-list
/// </summary>
public class _19
{
    public ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        if (head.next == null) return null;

        ListNode behind = head;
        ListNode next = head;
        for (int i = 1; i < n; i++)
        {
            next = next?.next;
        }
        while (next?.next != null)
        {
            next = next.next;
            behind = behind.next;
        }
        behind.next = behind.next.next;
        return head;
    }
}
