// Link: https://leetcode.com/problems/number-of-provinces

// Using DFS
// Time: O(n) => 2n = vertices + edges
// Space: O(n^2)

public class Solution {
  public int FindCircleNum(int[][] isConnected) {
    var visited = new bool[isConnected.Length];

    var counter = 0;
    for (int i = 0; i < isConnected.Length; i++) {
      // Check Connected Component
      if (!visited[i]) {
        counter++;
        Traverse(i, ref isConnected, ref visited);
      }
    }

    return counter;
  }

  // Traverse Graph and consider one province (connected component)
  public static void Traverse(int cur, ref int[][] isConnected,
                              ref bool[] visited) {
    // DFS Traverse
    visited[cur] = true;
    for (int next = 0; next < isConnected.Length; next++) {
      if (isConnected[cur][next] == 1 && !visited[next]) {
        Traverse(next, ref isConnected, ref visited);
      }
    }
  }
}
