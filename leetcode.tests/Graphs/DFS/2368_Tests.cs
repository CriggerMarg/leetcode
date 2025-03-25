using FluentAssertions;
using leetcode.Graphs.DFS;

namespace leetcode.tests.Graphs.DFS;
public class _2368_Tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [7, new int[][] { [0, 1], [1, 2], [3, 1], [4, 0], [0, 5], [5, 6] }, new int[] { 4,5 }, 4],
				 [7, new int[][] { [0, 1], [0, 2], [0, 5], [0, 4], [3, 2], [6, 5] }, new int[] { 4, 2, 1 }, 3],
				 [2, new int[][] { [0, 1 ]}, new int[] {1 }, 1],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int n, int[][] edges, int[] restricted, int expected)
	{
		var test = new _2368();
		var rez = test.ReachableNodes(n, edges, restricted);
		rez.Should().Be(expected);
	}
}
