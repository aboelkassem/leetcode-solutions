// Link: https://leetcode.com/problems/eliminate-maximum-number-of-monsters

// Time: O(nlogn)
// Space: O(n)
public class Solution {
  public int EliminateMaximum(int[] dist, int[] speed) {
    var time = new double[dist.Length];
    for (int i = 0; i < dist.Length; i++) {
      time[i] = (double)dist[i] / speed[i];
    }

    Array.Sort(time);

    var count = 0;
    for (int i = 0; i < time.Length; i++) {
      if (time[i] <= i)
        break;

      count++;
    }

    return count;
  }
}