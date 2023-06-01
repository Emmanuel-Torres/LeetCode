namespace Problems.P1;

public class P1_Implementation
{
    public static int[] TwoSum(int[] nums, int target) 
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums [i] + nums[j] == target)
                    return new int [] {i, j};
            }
        }

        throw new InvalidOperationException($"Could not find a pair of indices that add up to {target}");
    }
}