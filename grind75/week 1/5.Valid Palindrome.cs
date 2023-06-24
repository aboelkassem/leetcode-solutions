// Link: https://leetcode.com/problems/valid-palindrome

// Time: O(1)
// Space: O(1)

using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        // exceptions for empty values
        if (string.IsNullOrEmpty(s))
            return true;
        
        var cleanText = Regex.Replace(s.ToLower().Trim(), @"[^0-9a-z]", "");

        // exceptions for one character
        if (cleanText.Length == 1)
            return true;

        var leftString = cleanText.Substring(0, cleanText.Length / 2);
        if (cleanText.Length % 2 == 0) // is even
        {
            var reversedRightString = Reverse(cleanText.Substring(cleanText.Length / 2));
            if (leftString == reversedRightString)
                return true;
            else
                return false;
        }
        else
        {
            var reversedRightString = Reverse(cleanText.Substring(cleanText.Length / 2 + 1));
            if (leftString == reversedRightString)
                return true;
            else
                return false;
        }
    }

    public string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new String(chars);
    }
}