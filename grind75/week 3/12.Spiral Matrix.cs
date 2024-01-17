// Link: https://leetcode.com/problems/spiral-matrix

// Using brute force
// Time:  O(n)
// Space:  O(n)
public class Solution {
  public IList<int> SpiralOrder(int[][] matrix) {
    IList<int> records = new List<int>();

    // 4 boundary pointers
    int rowStart = 0;                  // left boundary
    int colStart = 0;                  // top boundary
    int rowEnd = matrix[0].Length - 1; // right boundary
    int colEnd = matrix.Length - 1;    // bottom boundary

    while (colStart <= colEnd && rowStart <= rowEnd) {
      // Row traversal
      for (int i = rowStart; i <= rowEnd; i++) {
        records.Add(matrix[colStart][i]);
      }
      colStart++;
      // Column traversal
      if (colStart > colEnd)
        break;
      for (int j = colStart; j <= colEnd; j++) {
        records.Add(matrix[j][rowEnd]);
      }
      rowEnd--;
      // Reverse row traversal
      if (rowStart > rowEnd)
        break;
      for (int k = rowEnd; k >= rowStart; k--) {
        records.Add(matrix[colEnd][k]);
      }
      colEnd--;
      // Reverse column traversal
      if (colStart > colEnd)
        break;
      for (int m = colEnd; m >= colStart; m--) {
        records.Add(matrix[m][rowStart]);
      }
      rowStart++;
      if (rowStart > rowEnd)
        break;
    }
    return records;
  }
}