// Link: https://leetcode.com/problems/word-search

// Using DFS and Backtracking
// Time:  O(N*M*4^K) where K = WordLength
// Space:  O(n*m)
public class Solution {
  public bool Exist(char[][] board, string word) {
    var rowsLength = board.Length;
    var colsLength = board[0].Length;

    var path = new HashSet<(int, int)>();

    bool DFS(int r, int c, int curIdx) {
      // base cases

      // finished looping (found a word) -- valid condition
      if (curIdx == word.Length)
        return true;

      // out of bound  -- invalid condition
      if (r < 0 || c < 0 || r >= rowsLength || c >= colsLength)
        return false;

      // wrong character or visited position before -- invalid condition
      if (word[curIdx] != board[r][c] || path.Contains((r, c)))
        return false;

      path.Add((r, c));

      // options
      var result = (DFS(r + 1, c, curIdx + 1) || DFS(r - 1, c, curIdx + 1) ||
                    DFS(r, c + 1, curIdx + 1) || DFS(r, c - 1, curIdx + 1));

      path.Remove((r, c));
      return result;
    }

    // brute force for each starting point
    for (int i = 0; i < rowsLength; i++) {
      for (int j = 0; j < colsLength; j++) {
        if (DFS(i, j, 0))
          return true;
      }
    }

    return false;
  }
}
