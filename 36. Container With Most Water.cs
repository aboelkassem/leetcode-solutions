// Link: https://leetcode.com/problems/container-with-most-water

// Time: O(n)
// Space: O(n)

// using two pointers and greedy algorithm
public class Solution {
  public int MaxArea(int[] height) {
    var maxArea = 0;
    var left = 0;
    var right = height.Length - 1;

    while (left < right) {
      // area = height (minimum) * width (distance between two pointers)
      var currArea = Math.Min(height[left], height[right]) * (right - left);
      // update max area
      maxArea = Math.Max(maxArea, currArea);

      if (height[left] < height[right])
        left++;
      else
        right--;
    }

    return maxArea;
  }
}