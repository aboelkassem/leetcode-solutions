// Link: https://leetcode.com/problems/longest-substring-without-repeating-characters

// using sliding window
// Time: O(n)
// Space: O(min(n,m))
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var charSet = new HashSet<char>();
        int left = 0, right = 0, maxLength = 0;
        while(right < s.Length)
        {
            if (!charSet.Contains(s[right]))
            {
                charSet.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, charSet.Count);
            }
            else
            {
                charSet.Remove(s[left]);
                left++;
            }
        }
        return maxLength;
    }
}

// using a list to remember the substring length
// Time: O(n)
// Space: O(n)
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> letters = new List<char>();
        int maxLength = 0;
        
        foreach (char c in s) {
            if (!letters.Contains(c)) {
                letters.Add(c);
            }
            else {
                maxLength = Math.Max(maxLength, letters.Count);
                
                // remove preceding characters up to the duplicate letter
                int idx = letters.IndexOf(c);
                letters.RemoveRange(0, idx+1);

                letters.Add(c);
            }
        }
        
        return Math.Max(maxLength, letters.Count); 
    }
}