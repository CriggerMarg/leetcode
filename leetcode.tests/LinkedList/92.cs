using FluentAssertions;
using leetcode.LinkedList;
using leetcode.tests.Helpers;

namespace leetcode.tests.LinkedList;

public class _92_tests
{

    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                 [ListNodeGenerator.GenerateLinkedList(1,6), 2,5, ListNodeGenerator.GenerateLinkedList([1, 5, 4, 3, 2, 6])],
                // [ListNodeGenerator.GenerateLinkedList([5]), 1,1, ListNodeGenerator.GenerateLinkedList([5])],
                // [ListNodeGenerator.GenerateLinkedList([3, 5]), 1,1, ListNodeGenerator.GenerateLinkedList([3, 5])],
                 //[ListNodeGenerator.GenerateLinkedList([3, 5]), 1,2, ListNodeGenerator.GenerateLinkedList([5, 3])],
            ];
    }

    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(ListNode head, int left, int right, ListNode expected)
    {
        var test = new _92();
        var rez = test.ReverseBetween(head, left, right);
        rez.Should().BeEqualLinkedList(expected);
    }
}
