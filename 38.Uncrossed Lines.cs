// Link: https://leetcode.com/problems/uncrossed-lines

// Time: O(m * n)
// Space: O(m * n)

// using dynamic programming
public class Solution {
  public int MaxUncrossedLines(int[] nums1, int[] nums2) {
    // initialize dp array with -1
    var dp = new int[nums1.Length, nums2.Length];
    for (int i = 0; i < nums1.Length; i++)
      for (int j = 0; j < nums2.Length; j++)
        dp[i, j] = -1;
    return Recurse(0, 0, nums1, nums2, dp);
  }

  private int Recurse(int idx1, int idx2, int[] nums1, int[] nums2, int[,] dp) {
    // base case
    if (idx1 >= nums1.Length || idx2 >= nums2.Length)
      return 0;

    // memoization
    if (dp[idx1, idx2] != -1)
      return dp[idx1, idx2];

    // transition
    if (nums1[idx1] == nums2[idx2])
      // if the numbers are equal, then we can draw a line
      dp[idx1, idx2] = 1 + Recurse(idx1 + 1, idx2 + 1, nums1, nums2, dp);
    else
      // if the numbers are not equal, then we can't draw a line
      // so we move to the next number in nums1 or nums2
      // and take the max of the two
      // this is because we want to maximize the number of lines we can draw
      dp[idx1, idx2] = Math.Max(Recurse(idx1 + 1, idx2, nums1, nums2, dp),
                                Recurse(idx1, idx2 + 1, nums1, nums2, dp));
    return dp[idx1, idx2];
  }
}
