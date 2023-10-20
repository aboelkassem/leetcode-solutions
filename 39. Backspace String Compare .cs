// Link: https://leetcode.com/problems/backspace-string-compare

// using stack
// Time: O(n)
// Space: O(n)

public class Solution {
  public bool BackspaceCompare(string s, string t) {
    return CleanString(s) == CleanString(t);
  }

  private static string CleanString(string s) {
    Stack<char> stack = new Stack<char>();
    foreach (var c in s) {
      if (c != '#')
        stack.Push(c);
      else if (stack.Count > 0) // remove latest added one
        stack.Pop();
    }

    return String.Join(",", stack);
  }
}