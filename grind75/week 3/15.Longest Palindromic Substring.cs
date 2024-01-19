// Link: https://leetcode.com/problems/longest-palindromic-substring

// Using Two pointers
// Time:  O(n^3)
// Space:  O(1)
public class Solution {
    public string LongestPalindrome(string s) {
        for (int length = s.Length; length > 0; length--)
        {
            for (int start = 0; start <= s.Length - length; start++)
            {
                if (IsPalindrome(start, start + length, s))
                {
                    return s.Substring(start, length);
                }
            }
        }

        return "";
    }

    public bool IsPalindrome(int i, int j, string s)
    {
        // using two pointers
        int left = i;
        int right = j - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }
        return true;
    }
}

// Using expand from center and two pointers
// Time:  O(n^2)
// Space:  O(1)
public class Solution {
    public string LongestPalindrome(string s) {
        if (s.Length < 2)
            return s;

        var res = string.Empty;
        var resLen = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // Case 1:
            // odd length
            // initial two pointers at the center
            var left = i;
            var right = i;

            // expand outwards
            // if this condition satisfies, then its a palindrome
            while (left >=0 && right < s.Length && s[left] == s[right])
            {
                var palindromeLength = right - left + 1;
                if (palindromeLength > resLen)
                {
                    res = s.Substring(left, palindromeLength);
                    resLen = palindromeLength;
                }

                left--;
                right++;
            }

            // Case 2: even length
            // even length
            left = i;
            right = i + 1;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                var palindromeLength = right - left + 1;
                if (palindromeLength > resLen)
                {
                    res = s.Substring(left, palindromeLength);
                    resLen = palindromeLength;
                }

                left--;
                right++;
            }
        }

        return res;
    }
}