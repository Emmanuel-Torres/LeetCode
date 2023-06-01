using Problems.P3;

namespace Problems.Tests.P3;

public class P3_Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    [TestCase(" ", 1)]
    [TestCase(" 1234", 5)]
    [TestCase("123443", 4)]
    [TestCase("dvdf", 3)]
    public void Test(string s, int expected)
    {
        var sut = new P3_Implementation();
        var res = sut.LengthOfLongestSubstring(s);

        res.Should().Be(expected);
    }
}