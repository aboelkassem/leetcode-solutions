// Link: https://leetcode.com/problems/partition-equal-subset-sum

// Using DP and backracking
// Time:  O(n)
// Space:  O(n)
public class Solution {
    IDictionary<(int, int), bool> dp = null;
    public bool CanPartition(int[] nums) {
        dp = new Dictionary<(int, int), bool>();
        int sum = nums.Sum();
        if(sum % 2 != 0)
            return false;

        int target =  sum / 2;
        return BackTracking(nums, target, 0);
    }
    private bool BackTracking(int[] nums, int target, int index)
    {
        if (target == 0)
            return true;
        
        if (target < 0 || index == nums.Length)
            return false;
        
        if (dp.ContainsKey((index, target)))
            return dp[(index, target)];
        
        // It is 0/1 Knapsack Problem i.e it has 2 choices include the nums[index] or don't inlcude nums[index]
        var result = BackTracking(nums, target - nums[index], index + 1) || BackTracking(nums, target, index + 1);
        
        dp[(index, target)] = result;
        return result;
    }
}