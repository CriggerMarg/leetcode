using FluentAssertions;
using leetcode.Backtracking;

namespace leetcode.tests.Backtracking;

public class _17_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				["23", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }],
				["22", new string[] { "aa", "ab", "ac", "ba", "bb", "bc", "ca", "cb", "cc" }],
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(string input, string[] expected)
	{
		var test = new _17();
		var rez = test.LetterCombinations(input);
		rez.Should().BeEquivalentTo(expected);
	}
}
