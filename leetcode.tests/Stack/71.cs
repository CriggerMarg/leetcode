using FluentAssertions;
using leetcode.Stack;

namespace leetcode.tests.Stack;

public class _71_tests
{

	[Theory]
	[InlineData("/home/", "/home")]
	[InlineData("/../", "/")]
	[InlineData("/home//foo/", "/home/foo")]
	[InlineData("/home/user/Documents/../Pictures", "/home/user/Pictures")]
	[InlineData("/.../a/../b/c/../d/./", "/.../b/d")]
	public void TestCases(string input, string expected)
	{
		var test = new _71();
		var rez = test.SimplifyPath(input);
		rez.Should().Be(expected);
	}
}
