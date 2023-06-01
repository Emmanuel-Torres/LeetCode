using Problems.P4;

namespace Problems.Tests.P4;

public class P4_Tests
{
    [Test]
    [TestCase(new int[] {1, 3}, new int[] {2}, 2)]
    [TestCase(new int[] {1, 2}, new int[] {3, 4}, 2.5)]
    public void Test(int[] nums1, int[] nums2, double expected)
    {
        var sut = new P4_Implementation();
        var res = sut.FindMedianSortedArrays(nums1, nums2);

        res.Should().Be(expected);
    }
}