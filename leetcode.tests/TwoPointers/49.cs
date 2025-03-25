using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;
public class _49_tests
{
	public class TestData
	{
		public static IEnumerable<object[]> MatchesAndExpectedOutput =>
		[
			[
				new string[] { "eat", "tea", "tan", "ate", "nat", "bat" },
				new string[][]
				{
					["bat"],
					["nat", "tan"],
					["ate", "eat", "tea"]
				}
			],
			[
				new string[]{ "cab", "tin", "pew", "duh", "may", "ill", "buy", "bar", "max", "doc" },
				new string[][]
				{
					["max"],
					["buy"],
					["doc"],
					["may"],
					["ill"],
					["duh"],
					["tin"],
					["bar"],
					["pew"],
					["cab"]
				}
			]
		];
	}

	[Theory]
	[MemberData(nameof(TestData.MatchesAndExpectedOutput), MemberType = typeof(TestData))]
	public void TestCases(string[] input, string[][] expected)
	{
		var test = new _49();

		var isValid = test.GroupAnagrams(input);
		isValid.Should().BeEquivalentTo(expected);
	}
}
