using FluentAssertions;
using leetcode.BST;
using leetcode.Graphs.DFS;
using leetcode.tests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.tests.Graphs.DFS;
public class _547_tests
{

	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [new int[][] { [1, 1, 0], [1, 1, 0], [0, 0, 1] }, 2],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[][] graph,  int expected)
	{
		var test = new _547();
		var rez = test.FindCircleNum(graph);
		rez.Should().Be(expected);
	}
}
