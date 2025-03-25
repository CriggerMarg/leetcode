using FluentAssertions;
using leetcode.LinkedList;
using leetcode.tests.Helpers;

namespace leetcode.tests.LinkedList;

public class _2095_Tests
{

    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                 [ListNodeGenerator.GenerateLinkedList([1, 3, 4, 7, 1, 2, 6]),ListNodeGenerator.GenerateLinkedList([1, 3, 4, 1, 2, 6])],
                 [ListNodeGenerator.GenerateLinkedList([1, 2, 3, 4]),ListNodeGenerator.GenerateLinkedList([1, 2,  4])],
                 [ListNodeGenerator.GenerateLinkedList([2,1]),ListNodeGenerator.GenerateLinkedList([2])],
            ];
    }
    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(ListNode head, ListNode expected)
    {
        var test = new _2095();
        var rez = test.DeleteMiddle(head);
        rez.Should().BeEqualLinkedList(expected);
    }
}
