// Link: https://leetcode.com/problems/find-minimum-in-rotated-sorted-array

// Time: O(log(n))
// Space: O(1)

public class Solution {
    public int FindMin(int[] nums) {
        var left = 0;
        var right = nums.Length - 1;

        while (right > left)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] > nums[right])
                left = mid + 1;
            else
                right = mid;
        }

        return nums[left];
    }
}