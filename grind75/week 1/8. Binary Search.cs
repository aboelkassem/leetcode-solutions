// Link: https://leetcode.com/problems/binary-search

// Time: O(log n)
// Space: O(1)

public class Solution {
    public int Search(int[] nums, int target) {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}