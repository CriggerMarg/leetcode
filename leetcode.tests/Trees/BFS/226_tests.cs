using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.BFS;

namespace leetcode.tests.Trees.BFS;
public class _226_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [new int?[] { 4, 2, 7, 1, 3, 6, 9 },new int?[] { 4, 7, 2, 9, 6, 3, 1 }],
				 [new int?[] { 2, 1, 3 },new int?[] { 2, 3, 1 }],
				 [new int?[] { 1,2},new int?[] { 1, null, 2 }],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int?[] left, int?[] expected)
	{
		var test = new _226();
		var p = TreeHelper.BuildTreeFromLevelOrder(left);
		var rez = test.InvertTree(p);
		var e = TreeHelper.BuildTreeFromLevelOrder(expected);
		rez.Should().BeEquivalentTo(e);
	}
}
