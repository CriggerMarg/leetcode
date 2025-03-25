using FluentAssertions;
using leetcode.Heap;

namespace leetcode.tests.Heap;

public class _1167_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				[new int[] {2,4,3 },14],
				[new int[] { 1, 8, 3, 5 },30],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[] input, int expected)
	{
		var test = new _1167();
		var rez = test.ConnectSticks(input);
		rez.Should().Be(expected);
	}
}
