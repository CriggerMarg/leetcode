using FluentAssertions;
using leetcode.Graphs;
using leetcode.Graphs.DFS;

namespace leetcode.tests.Graphs.DFS;
public class _323_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [5, new int[][] { [0, 1], [1, 2], [3, 4] }, 2],
				 [5, new int[][] { [0, 1], [1, 2], [2, 3], [3, 4] }, 1],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int n, int[][] graph, int expected)
	{
		var test = new _323();
		var rez = test.CountComponents(n, graph);
		rez.Should().Be(expected);
	}
}
