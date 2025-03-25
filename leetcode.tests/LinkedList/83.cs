using FluentAssertions;
using leetcode.LinkedList;

namespace leetcode.tests.LinkedList;
public class _83_Tests
{
    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [
                [new ListNode(1, new (1, new (2)))],
                [new ListNode(1, new (1, new (2, new (3, new (3)))))],
                [new ListNode(1, new (1, new (1, new (1, new (1)))))],
            ];
    }
    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(ListNode head)
    {
        var test = new _83();
        var rez = test.DeleteDuplicates(head);
        int curr = rez.val;
        while (rez.next != null)
        {
            curr.Should().NotBe(rez.next.val);
            curr = rez.next.val;
            rez = rez.next;
        }
    }
}
