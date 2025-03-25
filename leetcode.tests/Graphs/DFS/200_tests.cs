using FluentAssertions;
using leetcode.Graphs.DFS;

namespace leetcode.tests.Graphs.DFS;
public class _200_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [new char[][]
				 {
					['1','1','1','1','0'],
					['1','1','0','1','0'],
					['1','1','0','0','0'],
					['0','0','0','0','0']
				 },
				 1],
			 [new char[][]
				 {
					['1','1','0','0','0'],
					['1','1','0','0','0'],
					['0','0','1','0','0'],
					['0','0','0','1','1']
				 },
				 3],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(char[][] graph, int expected)
	{
		var test = new _200();
		var rez = test.NumIslands(graph);
		rez.Should().Be(expected);
	}
}
