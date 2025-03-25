using FluentAssertions;
using leetcode.Strings;

namespace leetcode.tests.Strings;
public class _8_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
			[
				["42",42],
				[" -042",-42],
				["1337c0d3",1337],
				["0-1",0],
				["words and 987",0],
				["-91283472332", -2147483648]
			];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(string input, int expected)
	{
		var test = new _8();
		var rez = test.MyAtoi(input);
		rez.Should().Be(expected);
	}
}
