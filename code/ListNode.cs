namespace code
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public override int GetHashCode()
        {
            return val.GetHashCode() ^ 31;
        }

        public override bool Equals(object? obj)
        {
            var other = obj as ListNode;
            if (other == null)
            {
                return false;
            }

            if (next != null)
            {
                return other.val == val && next.Equals(other.next);
            }

            return other.val == val;
        }
    }
}
