using FluentAssertions;
using leetcode.LinkedList;

namespace leetcode.tests.LinkedList;

public class _867_Tests
{
    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                [new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))),3],
                [new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))),4]
            ];
    }

    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(ListNode head, int expected)
    {
        var test = new _876();
        var rez = test.MiddleNode(head);
        rez.val.Should().Be(expected);
    }
}
