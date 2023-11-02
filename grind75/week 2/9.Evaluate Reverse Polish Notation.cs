// Link: https://leetcode.com/problems/evaluate-reverse-polish-notation

// using stack
// Time: O(n)
// Space: O(n)

public class Solution {
  public int EvalRPN(string[] tokens) {
    // special case
    if (tokens.Length == 1)
      return Convert.ToInt32(tokens[0]);

    var result = 0;

    var stack = new Stack<int>();

    foreach (var token in tokens) {
      if (token == "/") {
        stack.TryPop(out var firstElement);
        stack.TryPop(out var secondElement);

        result = secondElement / firstElement;
        stack.Push(result);
      } else if (token == "*") {
        stack.TryPop(out var firstElement);
        stack.TryPop(out var secondElement);

        result = secondElement * firstElement;
        stack.Push(result);
      } else if (token == "+") {
        stack.TryPop(out var firstElement);
        stack.TryPop(out var secondElement);

        result = secondElement + firstElement;
        stack.Push(result);
      } else if (token == "-") {
        stack.TryPop(out var firstElement);
        stack.TryPop(out var secondElement);

        result = secondElement - firstElement;
        stack.Push(result);
      } else {
        stack.Push(Convert.ToInt32(token));
      }
    }

    return result;
  }
}
