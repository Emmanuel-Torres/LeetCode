namespace Problems.P4;

public class P4_Implementation
{
    public P4_Implementation()
    {
    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var merged = MergeArrays(nums1, nums2);
        return ComputeMedian(merged);
    }

    private static int[] MergeArrays(int[] nums1, int[] nums2)
    {
        var totalNumbers = nums1.Length + nums2.Length;
        var merged = new int[totalNumbers];
        var j = 0;
        var k = 0;

        for (var i = 0; i < totalNumbers; i++)
        {
            if (j >= nums1.Length)
            {
                merged[i] = nums2[k];
                k++;
            }
            else if (k >= nums2.Length)
            {
                merged[i] = nums1[j];
                j++;
            }
            else if (nums2[k] < nums1[j])
            {
                merged[i] = nums2[k];
                k++;
            }
            else
            {
                merged[i] = nums1[j];
                j++;
            }
        }

        return merged;
    }

    private static double ComputeMedian(int[] nums)
    {
        var len = nums.Length;

        if (len % 2 == 0)
        {
            var mid = len / 2;
            return (double)(nums[mid] + nums[mid - 1]) / 2;
        }
        else
        {
            var mid = (len / 2);
            return nums[mid];
        }
    }
}