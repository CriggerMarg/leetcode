using FluentAssertions;
using FluentAssertions.Primitives;

namespace leetcode.tests.Helpers;
public static class ListNodeTestExtensions
{
	public static void BeEqualLinkedList(this ObjectAssertions assertions, ListNode expected)
	{
		ListNode? head = assertions.Subject as ListNode;
		if (expected != null)
			head.Should().NotBeNull();
		else
		{
			expected.Should().BeNull();
			return;
		}
		ListNode? left = head;
		ListNode? right = expected;
		do
		{
			left.val.Should().Be(right?.val);
			left = left.next;
			right = right?.next;
		}
		while (left?.next != null);

	}
}