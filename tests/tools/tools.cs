using code.structures;

namespace tests
{
    static class utils
    {
        public static ListNode InitListNode(int[] numbers)
        {
            var head = new ListNode(numbers[0]);
            var curr = head;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                var next = new ListNode(numbers[i]);
                curr = curr.next = next;
            }

            return head;
        }
    }
}