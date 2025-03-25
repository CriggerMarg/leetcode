using FluentAssertions;
using leetcode.LinkedList;
using leetcode.tests.Helpers;

namespace leetcode.tests.LinkedList;
public class _19_Tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				// [ListNodeGenerator.GenerateLinkedList([1, 2, 3, 4, 5]),2, ListNodeGenerator.GenerateLinkedList([1, 2, 3, 5])],
				// [ListNodeGenerator.GenerateLinkedList([1]),1, null],
				 [ListNodeGenerator.GenerateLinkedList([1,2]),2,ListNodeGenerator.GenerateLinkedList([2])]
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(ListNode head, int n, ListNode? expected)
	{
		var test = new _19();
		var rez = test.RemoveNthFromEnd(head, n);
		if (expected is null)
		{
			rez.Should().BeNull();
		}
		else
		{
			rez.Should().BeEqualLinkedList(expected);
		}
	}
}
