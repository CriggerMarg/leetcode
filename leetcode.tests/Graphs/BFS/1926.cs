using FluentAssertions;
using leetcode.Graphs.BFS;

namespace leetcode.tests.Graphs.BFS;

public class _1926_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [
					new char[][]
					 {
						['+','+','.','+'],
						['.','.','.','+'],
						['+','+','+','.']
					 },
					new int[] {1,2},
					1
				 ],
				[
					new char[][]
					 {
						['+','+','+'],
						['.','.','.'],
						['+','+','+']
					 },
					new int[] {1,0},
					2
				 ],
				 [
					new char[][]
					 {
						['.','+']
					 },
					new int[] {0,0},
					-1
				 ],
				 [
					new char[][]
					 {
						['.','.']
					 },
					new int[] {0,1},
					1
				 ],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(char[][] maze, int[] entrance, int expected)
	{
		var test = new _1926();
		var rez = test.NearestExit(maze, entrance);
		rez.Should().Be(expected);
	}
}
