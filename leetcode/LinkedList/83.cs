namespace leetcode.LinkedList;

/// <summary>
/// https://leetcode.com/problems/remove-duplicates-from-sorted-list/
/// </summary>
public class _83
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode? dummy = head;
        while (dummy != null)
        {
            while (dummy.next?.val == dummy.val)
            {
                dummy.next = dummy.next.next;
            }
            dummy = dummy.next;
        }
        return head;
    }
}
