using FluentAssertions;
using leetcode.Graphs.DFS;

namespace leetcode.tests.Graphs.DFS;
public class _695_Tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [new int[][]
				 {
					[0,0,1,0,0,0,0,1,0,0,0,0,0],
					[0,0,0,0,0,0,0,1,1,1,0,0,0],
					[0,1,1,0,1,0,0,0,0,0,0,0,0],
					[0,1,0,0,1,1,0,0,1,0,1,0,0],
					[0,1,0,0,1,1,0,0,1,1,1,0,0],
					[0,0,0,0,0,0,0,0,0,0,1,0,0],
					[0,0,0,0,0,0,0,1,1,1,0,0,0],
					[0,0,0,0,0,0,0,1,1,0,0,0,0]
				 },
				 6],
			 [new int[][]
				 {
					[0,0,0,0,0,0,0,0]
				 },
				 0],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[][] graph, int expected)
	{
		var test = new _695();
		var rez = test.MaxAreaOfIsland(graph);
		rez.Should().Be(expected);
	}
}
