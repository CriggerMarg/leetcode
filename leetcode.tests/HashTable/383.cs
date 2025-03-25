using FluentAssertions;
using leetcode.HashTable;

namespace leetcode.tests.HashTable;

public class _383Tests
{
	[Theory]
	[InlineData("a", "b", false)]
	[InlineData("aa", "ab", false)]
	[InlineData("aa", "aab", true)]
	public void TestCases(string ransomNote, string magazine, bool expected)
	{
		var test = new _383();
		var rez = test.CanConstruct(ransomNote, magazine);
		rez.Should().Be(expected);
	}
}
