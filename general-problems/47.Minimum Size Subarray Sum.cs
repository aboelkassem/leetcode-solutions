// Link: https://leetcode.com/problems/minimum-size-subarray-sum

// Using Sliding window
// Time: O(n)
// Space: O(1)
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        var windowSum = 0;
        var windowStart = 0;
        var minLen = int.MaxValue;
        for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
        {
            windowSum += nums[windowEnd];
            while (windowSum >= target)
            {
                var windowLen = windowEnd - windowStart + 1;
                minLen = Math.Min(minLen, windowLen);
                windowSum -= nums[windowStart];
                windowStart++;
            }
        }

        return minLen == int.MaxValue ? 0 : minLen;
    }
}