using FluentAssertions;
using leetcode.Heap;

namespace leetcode.tests.Heap;

public class _1962_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				[new int[] { 5, 4, 9 },2,12],
			];
	}
	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[] input, int k, int expected)
	{
		var test = new _1962();
		var rez = test.MinStoneSum(input, k);
		rez.Should().Be(expected);
	}
}
