// Link: https://leetcode.com/problems/find-all-anagrams-in-a-string

// Using Sliding window
// Time:  O(N)
// Space:  O(max(N,M))
public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        int n = s.Length, m = p.Length;
        var res = new List<int>();
        if (m > n) return res;

        var countP = CountCharacter(p);

        //Initial Window with smallest str length but in longest string
        var k = new StringBuilder();
        for (int i = 0; i < m; i++)
        {
            k.Append(s[i]);
        }
        var window = k.ToString();
        var countWindow = CountCharacter(window);

        if (IsAnagram(countP, countWindow)) 
            res.Add(0);

        //Sliding Window
        for (int i = m; i < n; i++)
        {
            window += s[i];
            // shifting
            countWindow[window[m] - 'a']++; // m = windowEnd => add one on last element
            countWindow[window[0] - 'a']--; // minus one from frist element
            window = window.Remove(0, 1);
            if (IsAnagram(countP, countWindow)) 
                res.Add(i - m + 1);
        }

        return res;
    }


    private int[] CountCharacter(string s)
    {
        var count = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
        }
        return count;
    }

    private bool IsAnagram(int[] a, int[] b)
    {
        for (int i = 0; i < 26; i++)
        {
            if (a[i] != b[i]) return false;
        }
        return true;
    }
}