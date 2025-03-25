using FluentAssertions;
using leetcode.tests.Helpers;
using leetcode.Trees.BFS;

namespace leetcode.tests.Trees.BFS;
public class _103_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [new int?[] { 3, 9, 20, null, null, 15, 7 },new List<List<int>> { new () { 3}, new() { 20, 9 }, new() { 15, 7 } }],
				 [new int?[] { 1 },new List<List<int>> { new() { 1 } }],
				 [new int?[] {  },new List<List<int>> {}],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int?[] left, List<List<int>> expected)
	{
		var test = new _103();
		var p = TreeHelper.BuildTreeFromLevelOrder(left);
		var rez = test.ZigzagLevelOrder(p);
		rez.Should().BeEquivalentTo(expected);
	}
}
