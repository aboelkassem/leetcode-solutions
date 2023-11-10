// Link: https://leetcode.com/problems/number-of-islands

// using DFS
// Time: O(n*m)
// Space: O(n*m)
public class Solution {
  public int NumIslands(char[][] grid) {
    int count = 0;
    for (int i = 0; i < grid.Length; i++) {
      for (int j = 0; j < grid[i].Length; j++) {
        if (grid[i][j] == '1') {
          count++;
          DFS(grid, i, j);
        }
      }
    }

    return count;
  }

  private void DFS(char[][] grid, int i, int j) {
    if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length ||
        grid[i][j] == '0') {
      return;
    }

    grid[i][j] = '0';
    DFS(grid, i + 1, j);
    DFS(grid, i - 1, j);
    DFS(grid, i, j + 1);
    DFS(grid, i, j - 1);
  }
}