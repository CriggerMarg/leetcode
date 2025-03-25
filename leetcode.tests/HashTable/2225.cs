using FluentAssertions;
using leetcode.HashTable;

namespace leetcode.tests.HashTable;
public class _2225Tests
{

    public class TestData
    {
        public static IEnumerable<object[]> MatchesAndExpectedOutput =>
            [[new int[][] { [1, 3], [2, 3], [3, 6], [5, 6], [5, 7], [4, 5], [4, 8], [4, 9], [10, 4], [10, 9] }, new List<IList<int>> { new List<int> { 1, 2, 10 }, new List<int> { 4, 5, 7, 8 } }]];
    }

    [Theory]
    [MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
    public void TestCases(int[][] matches, IList<IList<int>> output)
    {
        var test = new _2225();
        var rez = test.FindWinners(matches);
        rez[0].Should().Equal(output[0]);
        rez[1].Should().Equal(output[1]);
    }
}
