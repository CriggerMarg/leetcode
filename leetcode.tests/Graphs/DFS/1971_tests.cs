using FluentAssertions;
using leetcode.Graphs.DFS;

namespace leetcode.tests.Graphs.DFS;
public class _1971_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [3, new int[][] { [0, 1], [1, 2], [2, 0] }, 0, 2, true],
				 [6, new int[][] { [0, 1], [0, 2], [3, 5], [5, 4], [4, 3] }, 0, 5, false],
				 [10, new int[][] { [4, 3], [1, 4], [4, 8], [1, 7], [6, 4], [4, 2], [7, 4], [4, 0], [0, 9], [5, 4] }, 5, 9, true],
				 [1, new int[][] { }, 0, 0, true],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int n, int[][] edges, int source, int destination, bool expected)
	{
		var test = new _1971();
		var rez = test.ValidPath(n, edges, source, destination);
		rez.Should().Be(expected);
	}
}
