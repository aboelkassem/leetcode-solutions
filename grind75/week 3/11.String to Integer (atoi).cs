// Link: https://leetcode.com/problems/string-to-integer-atoi

// Using brute force
// Time:  O(n)
// Space:  O(1)
public class Solution {
    public int MyAtoi(string s) {
        var result = 0;
        var sign = 1;
        var i = 0;

        // Discard whitespaces in the beginning
        // i is the index of the first non-whitespace character
        while (i < s.Length && s[i] == ' ')
            i++;

        // Check if optional sign if it exists
        if (i < s.Length && (s[i] == '+' || s[i] == '-'))
            sign = s[i++] == '+' ? 1 : -1;

        // Build the result and check for overflow/underflow condition
        while (i < s.Length && s[i] >= '0' && s[i] <= '9')
        {
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && s[i] - '0' > 7))
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + (s[i++] - '0');
        }

        return result * sign;
    }
}