using FluentAssertions;
using leetcode.LinkedList;
using leetcode.tests.Helpers;
using static leetcode.tests.Helpers.ListNodeGenerator;

namespace leetcode.tests.LinkedList;
public class _23_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
			//	[new ListNode[]{LL([]),  }, LL([])],
				[new ListNode[]{LL([1]), LL( [0]),  }, LL([])],
			//	[new ListNode[]{LL([1, 4, 5]), LL([1, 3, 4]), LL([2, 6]) }, LL([1, 1, 2, 3, 4, 4, 5, 6])],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(ListNode[] input, ListNode expected)
	{
		var test = new _23();
		var rez = test.MergeKLists(input);
		rez.Should().BeEqualLinkedList(expected);
	}
}
