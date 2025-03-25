
using FluentAssertions;
using leetcode.Graphs.BFS;

namespace leetcode.tests.Graphs.BFS;

public class _133_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [
					new int[][]{[2,4],[1,3],[2,4],[1,3]},
					new int[][]{[2,4],[1,3],[2,4],[1,3]},
				 ],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[][] graph, int expected)
	{
		var test = new _133();
	//	var rez = test.CloneGraph(graph);
	//	rez.Should().Be(expected);
	}
}
