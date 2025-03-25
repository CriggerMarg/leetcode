using FluentAssertions;
using leetcode.HashTable;
using leetcode.TwoPointers;

namespace leetcode.tests.HashTable;
public class _73_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				[
					new int[][]{[1,1,1],[1,0,1],[1,1,1]},
					new int[][]{[1,0,1],[0,0,0],[1,0,1]},
				]
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[][] input, int[][] expected)
	{
		var test = new _73();
		 test.SetZeroes(input);
		input.Should().BeEquivalentTo(expected);
	}
}
