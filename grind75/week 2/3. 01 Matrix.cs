// Link: https://leetcode.com/problems/01-matrix

// Time: O(m * n)
// Space: O(m * n)
public class Solution {
  public int[][] UpdateMatrix(int[][] mat) {
    int rows = mat.Length;
    int cols = mat[0].Length;

    int[][] result = new int [rows][];
    for (int i = 0; i < rows; i++) {
      result[i] = new int[cols];
      for (int j = 0; j < cols; j++) {
        result[i][j] = int.MaxValue - 1; // Initialize to a large value

        if (mat[i][j] == 0) {
          result[i][j] = 0; // If it's 0, distance is 0
        } else {
          // Check left and top neighbors
          if (i > 0)
            result[i][j] = Math.Min(result[i][j], result[i - 1][j] + 1);
          if (j > 0)
            result[i][j] = Math.Min(result[i][j], result[i][j - 1] + 1);
        }
      }
    }

    for (int i = rows - 1; i >= 0; i--) {
      for (int j = cols - 1; j >= 0; j--) {
        // Check right and bottom neighbors
        if (i < rows - 1)
          result[i][j] = Math.Min(result[i][j], result[i + 1][j] + 1);
        if (j < cols - 1)
          result[i][j] = Math.Min(result[i][j], result[i][j + 1] + 1);
      }
    }

    return result;
  }
}
