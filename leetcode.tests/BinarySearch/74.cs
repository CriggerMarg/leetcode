using FluentAssertions;
using leetcode.BinarySearch;

namespace leetcode.tests.BinarySearch;

public class _74_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				[new int[][] { [1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60] },3,true],
				[new int[][] { [1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60] },13,false],
				[new int[][] { [1] },2,false],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[][] input, int target, bool expected)
	{
		var test = new _74();
		var rez = test.SearchMatrix(input, target);
		rez.Should().Be(expected);
	}
}
