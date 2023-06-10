public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target && i != j)
                    result = new int[] { i, j };
            }
        }

        return result;
    }
}