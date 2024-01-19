using System;
using System.Collections.Generic;

class Solution
{
    public static bool IsValid(string s)
    {
        Stack<char> stk = new Stack<char>();
        // special cases
        if (string.IsNullOrEmpty(s))
            return true;
        if (s.Length == 1)
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '{' || s[i] == '(' || s[i] == '[')
            {
                stk.Push(s[i]);
            }

            if (s[i] == '}' || s[i] == ')' || s[i] == ']')
            {
                if (stk.Count == 0)
                    return false;
                if (IsMatch(stk.Peek(), s[i]))
                    stk.Pop();
                else
                    return false;
            }
        }
        if (stk.Count == 0)
            return true;

        return false;
    }

    public static bool IsMatch(char s1, char s2)
    {
        if (s1 == '(' && s2 == ')')
            return true;
        else if (s1 == '{' && s2 == '}')
            return true;
        else if (s1 == '[' && s2 == ']')
            return true;
        else
            return false;
    }
}