namespace leetcode.LinkedList;

public class _2095
{
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head.next == null) return null;
        // сначала найдём середину с помощью slow-fast pointer
        // трюк здесь в том чтобы иметь prev для fast, ибо нам надо будет соединить prev с slow.next
        ListNode slow = head;
        ListNode? fast = head.next;
        ListNode prev = slow;
        while (fast != null || fast?.next != null)
        {
            prev = slow;
            slow = slow!.next!; // slow не может быть null он движется медленеее чем fast, но IDE этого не понять
            fast = fast.next?.next;
        }
        prev.next = slow.next;
        return head;
    }
}
