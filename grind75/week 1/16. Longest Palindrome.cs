// Link: https://leetcode.com/problems/longest-palindrome

// Time: O(n)
// Space: O(n)

public class Solution {
    public int LongestPalindrome(string s) {
        if (s.Length == 1)
            return 1;

        // get how many repetitions per each character
        var dic = new Dictionary<char, int>();
        foreach (var character in s)
        {
            if (dic.ContainsKey(character))
                dic[character]++;
            else
                dic.Add(character, 1);
        }

        // to get longest palindrome follow this formula
        // [Sum(dicEvenCount) + Sum(dicOddCount - 1)] + 1

        var result = 0;
        bool isOddFound = false;
        foreach (var ch in dic)
        {
            if (ch.Value % 2 == 0) // event
                result += ch.Value;
            else // odd
            {
                isOddFound = true;
                result += (ch.Value - 1);
            }
        }

        if (isOddFound)
            return result + 1;
        else
            return result;
    }
}