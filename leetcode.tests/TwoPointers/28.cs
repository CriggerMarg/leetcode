using FluentAssertions;
using leetcode.TwoPointers;

namespace leetcode.tests.TwoPointers;
public class _28_FindtheIndexoftheFirstOccurrenceinaStringTests
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("hello", "ll", 2)]
    [InlineData("aaa", "aaaa", -1)]
    [InlineData("mississippi", "issip", 4)]
    public void TestCases(string haystack, string needle, int output)
    {
        var test = new _28();
        int rez = test.StrStr(haystack, needle);
        rez.Should().Be(output);
    }
}
