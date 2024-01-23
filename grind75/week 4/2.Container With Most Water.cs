// Link: https://leetcode.com/problems/container-with-most-water

// Using two pointers
// Time: O(n)
// Space: O(1)
public class Solution {
    public int MaxArea(int[] height) {
        var maxArea = 0;
        var left = 0;
        var right = height.Length - 1;

        while (left < right)
        {
            // area = height (minimum) * width (distance between two pointers)
            var currArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, currArea);

            if (height[left] <= height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;   
    }
}