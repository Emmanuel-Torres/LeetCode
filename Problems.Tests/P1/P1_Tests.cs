using Problems.P1;

namespace Problems.Tests.P1;

public class P1_Tests
{
    [Test]
    [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [TestCase(new int[] { 3, 2, 4 },      6, new int[] { 1, 2 })]
    [TestCase(new int[] { 3, 3 },         6, new int[] { 0, 1 })]
    public void TestTwoSum(int[] input, int target, int[] output)
    {
        var result = P1_Implementation.TwoSum(input, target);
        result.Should().BeEquivalentTo(output);
    }
}