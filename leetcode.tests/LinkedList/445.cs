using FluentAssertions;
using leetcode.LinkedList;
using leetcode.tests.Helpers;
using static leetcode.tests.Helpers.ListNodeGenerator;

namespace leetcode.tests.LinkedList;
public class _445_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [GenerateLinkedList([7, 2, 4, 3]), GenerateLinkedList([5, 6, 4]), GenerateLinkedList([7, 8, 0, 7])],
				// [GenerateLinkedList([2, 4, 3]), GenerateLinkedList([5, 6, 4]), GenerateLinkedList([7, 0, 8])],
		//		 [GenerateLinkedList([0]), GenerateLinkedList([0]), GenerateLinkedList([0])],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(ListNode l1, ListNode l2, ListNode expected)
	{
		var test = new _445();
		var rez = test.AddTwoNumbers(l1, l2);
		rez.Should().BeEqualLinkedList(expected);
	}
}
