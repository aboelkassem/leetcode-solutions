// Link: https://leetcode.com/problems/rotting-oranges

// using BFS
// Time: O(n*m)
// Space: O(n*m)
public class Solution {
  public int OrangesRotting(int[][] grid) {
    if (grid.Length == 0)
      return 0;

    int result = 0;
    Queue<(int, int)> bfs = new Queue<(int, int)>();

    int rows = grid.Length;
    int cols = grid[0].Length;

    for (int i = 0; i < rows; i++) {
      for (int j = 0; j < cols; j++) {
        if (grid[i][j] == 2) {
          bfs.Enqueue((i, j));
        }
      }
    }

    while (bfs.Any()) {
      Queue<(int, int)> newBfs = new Queue<(int, int)>();
      // A flag to check if any adjacent oranges are being affected
      // If not, we will not increase the time unit
      bool effective = false;
      while (bfs.Any()) {
        (int i, int j) = bfs.Dequeue();
        // Top
        if (i - 1 > -1 && grid[i - 1][j] == 1) {
          grid[i - 1][j] = 2;
          effective = true;
          newBfs.Enqueue((i - 1, j));
        }

        // Bottom
        if (i + 1 < rows && grid[i + 1][j] == 1) {
          grid[i + 1][j] = 2;
          effective = true;
          newBfs.Enqueue((i + 1, j));
        }

        // Left
        if (j - 1 > -1 && grid[i][j - 1] == 1) {
          grid[i][j - 1] = 2;
          effective = true;
          newBfs.Enqueue((i, j - 1));
        }

        // Right
        if (j + 1 < cols && grid[i][j + 1] == 1) {
          grid[i][j + 1] = 2;
          effective = true;
          newBfs.Enqueue((i, j + 1));
        }
      }

      if (!bfs.Any() && effective) {
        result++;
      }
      bfs = newBfs;
    }

    for (int i = 0; i < rows; i++) {
      for (int j = 0; j < cols; j++) {
        if (grid[i][j] == 1) {
          return -1;
        }
      }
    }

    return result;
  }
}
