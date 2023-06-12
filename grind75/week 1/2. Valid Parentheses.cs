// Link: https://leetcode.com/problems/valid-parentheses

// Brute-Force
// Time: O(n)
// Space: O(n)

public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach (var prant in s)
        {
            if (stack.Count == 0)
            {
                stack.Push(prant);
            }
            else if (prant == '{' || prant == '}')
            {
                if (prant == '}' && stack.Peek() == '{')
                    stack.Pop();
                else
                    stack.Push(prant);
            }
            else if (prant == '[' || prant == ']')
            {
                if (prant == ']' && stack.Peek() == '[')
                    stack.Pop();
                else
                    stack.Push(prant);
            }
            else if (prant == '(' || prant == ')')
            {
                if (prant == ')' && stack.Peek() == '(')
                    stack.Pop();
                else
                    stack.Push(prant);
            }

        }


        if (stack.Count == 0)
            return true;
        else
            return false;
    }
}