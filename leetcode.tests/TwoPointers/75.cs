using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;

public class _75_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				[ new int[] { 2, 0, 2, 1, 1, 0 },  new int[] { 0, 0, 1, 1, 2, 2 }],
				[ new int[] { 2, 0, 1 },  new int[] { 0,  1, 2 }],
				[ new int[] { 0, 0 },  new int[] { 0, 0 }],
				[ new int[] { 1, 0, 1 },  new int[] { 0, 1, 1 }],
				[ new int[] { 1, 0, 2 },  new int[] { 0, 1, 2 }],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(int[] input, int[] expected)
	{
		var test = new _75();
		test.SortColors(input);
		input.Should().BeEquivalentTo(expected);
	}
}
