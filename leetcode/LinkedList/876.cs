namespace leetcode.LinkedList;

/// <summary>
/// https://leetcode.com/problems/middle-of-the-linked-list/
/// </summary>
public class _876
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode? slow = head;
        ListNode? fast = head;
        /*
         Эта залупа работает следующим образом:
         пока мы быстрым указателем бежим x2 ноды за раз, медленный бежит одну
         и когда быстрый прибегает в конец - медленный будет на середине
         */
        while (fast != null && fast.next != null)
        {
            slow = slow?.next;
            fast = fast.next?.next;
        }
        return slow!;
    }
}
