// Link: https://leetcode.com/problems/furthest-building-you-can-reach

// Time: O(n)
// Space: O(n)

public class Solution {
  public int FurthestBuilding(int[] heights, int bricks, int ladders) {
    var maxDiff = new PriorityQueue<int, int>();
    int sum = 0;
    for (int i = 1; i < heights.Length; i++) {
      var next = heights[i] - heights[i - 1];
      if (next > 0) {
        // Push the value with priority as index
        maxDiff.Enqueue(next, -next);
        sum += next; // use bricks with distance between buildings
      }

      // If sum is greater than bricks, then we need to use ladder
      if (sum > bricks) {
        // If we have ladders, then we can use it
        if (ladders > 0) {
          // Get the max diff and remove it from sum
          sum -= maxDiff.Dequeue();
          ladders--;
        } else {
          return i - 1;
        }
      }
    }
    return heights.Length - 1;
  }
}