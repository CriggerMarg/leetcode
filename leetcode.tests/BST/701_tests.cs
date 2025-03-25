using FluentAssertions;
using leetcode.BST;
using leetcode.tests.Helpers;

namespace leetcode.tests.BST;
public class _701_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				 [new int?[] { 4, 2, 7, 1, 3 },5,new int?[] {5, 4, 7, 2,null,null,null, 1, 3 }],
				 [new int?[] { 40,20,60,10,30,50,70},25, new int?[] { 40,25,60,20,30,50,70,10,null }],
				 [new int?[] { 55,28,92,26,43,null,null,null,null,null,null},1, new int?[] { 55, 28, 92, 26, 43, 1 }]
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int?[] tree, int val, int?[] expected)
	{
		var test = new _701();
		var t = TreeHelper.BuildTreeFromLevelOrder(tree);
		var rez = test.InsertIntoBST(t, val);
		var e = TreeHelper.BuildTreeFromLevelOrder(expected);
		rez.Should().BeEquivalentTo(e);
	}
}
