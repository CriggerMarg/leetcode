namespace leetcode.tests.Helpers;
internal class ListNodeGenerator
{

    public static ListNode GenerateLinkedList(int start, int end)
    {
        var head = new ListNode(start);
        int curr = start + 1;
        var currNode = head;
        while (curr <= end)
        {
            var node = new ListNode(curr);
            currNode.next = node;
            currNode = node;
            curr++;
        }
        return head;
    }

    public static ListNode? LL(int[] arr)
    {
        return GenerateLinkedList(arr);
    }

    public static ListNode? GenerateLinkedList(int[] arr)
    {
        if (arr.Length == 0) return null;
        var head = new ListNode(arr[0]);
        int curr = 1;
        var currNode = head;
        while (curr < arr.Length)
        {
            var node = new ListNode(arr[curr]);
            currNode.next = node;
            currNode = node;
            curr++;
        }
        return head;
    }
}
