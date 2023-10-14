// Link: https://leetcode.com/problems/unique-paths-ii

// Time: O(m * n)
// Space: O(m * n)

// using dynamic programming
public class Solution {
  public int UniquePathsWithObstacles(int[][] obstacleGrid) {
    var dp = new int[obstacleGrid.Length, obstacleGrid[0].Length];
    return ExplorePath(obstacleGrid, 0, 0, dp);
  }

  private int ExplorePath(int[][] obstacleGrid, int row, int col, int[,] dp) {
    // base cases
    // invalid path
    if (row >= obstacleGrid.Length || col >= obstacleGrid[0].Length)
      return 0;
    if (obstacleGrid[row][col] == 1)
      return 0;
    // valid path
    if (row == obstacleGrid.Length - 1 && col == obstacleGrid[0].Length - 1)
      return 1;

    if (dp[row, col] != 0)
      return dp[row, col];

    // go down and right
    dp[row, col] = ExplorePath(obstacleGrid, row + 1, col, dp) +
                   ExplorePath(obstacleGrid, row, col + 1, dp);
    return dp[row, col];
  }
}
