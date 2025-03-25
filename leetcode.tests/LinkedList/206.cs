using FluentAssertions;
using leetcode.LinkedList;
using leetcode.tests.Helpers;

namespace leetcode.tests.LinkedList;
public class _206_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [ListNodeGenerator.GenerateLinkedList([1, 2, 3, 4, 5]),ListNodeGenerator.GenerateLinkedList([5, 4, 3, 2, 1])]
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(ListNode head, ListNode? expected)
	{
		var test = new _206();
		var rez = test.ReverseList(head);
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
