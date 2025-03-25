using FluentAssertions;
using leetcode.LinkedList;
using leetcode.tests.Helpers;
using static leetcode.tests.Helpers.ListNodeGenerator;

namespace leetcode.tests.LinkedList;
public class _21_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				// [GenerateLinkedList([1, 2, 4]), GenerateLinkedList([1, 3, 4]), GenerateLinkedList([1, 1, 2, 3, 4, 4])],
				// [GenerateLinkedList([]), GenerateLinkedList([]), GenerateLinkedList([])],
				// [GenerateLinkedList([]), GenerateLinkedList([0]), GenerateLinkedList([0])],
				 [GenerateLinkedList([-9, 3]), GenerateLinkedList([5, 7]), GenerateLinkedList([-9, 3, 5, 7])],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(ListNode? l1, ListNode? l2, ListNode? expected)
	{
		var test = new _21();
		var rez = test.MergeTwoLists(l1, l2);
		rez.Should().BeEqualLinkedList(expected);
	}
}
