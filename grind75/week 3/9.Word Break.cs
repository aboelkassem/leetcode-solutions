// Link: https://leetcode.com/problems/word-break

// Using Using Array of boolean
// Time:  O(n∗m): where n is the length of the input string s, m is the number of words in the wordDict list
// Space:  O(n)
public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        bool[] canSplit = new bool[s.Length + 1];
        canSplit[0] = true;
        for (int i = 1; i <= s.Length; i++)
        {
            foreach (var word in wordDict)
            {
                if (i < word.Length)
                {
                    continue;
                }

                var substring = s.Substring(i - word.Length, word.Length);
                if (substring == word && canSplit[i - word.Length])
                {
                    canSplit[i] = true;
                }
            }
        }

        return canSplit[s.Length];
    }
}

// Using DP and DFS
// - Time complexity: ( O(n * m + k) ), where ( n ) is the length of the string, ( m ) is the maximum length of a word in the dictionary, and ( k ) is the total number of characters in all words in the dictionary (for building the Trie).
// - Space complexity: ( O(n + k) ), where ( n ) is the length of the string and ( k ) is the total number of characters in all words in the dictionary.
public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        Dictionary<string, bool> memo = new Dictionary<string, bool>();
        HashSet<string> wordSet = new HashSet<string>(wordDict);
        return Dfs(s, wordSet, memo);
    }
    
    private bool Dfs(string s, HashSet<string> wordSet, Dictionary<string, bool> memo) {
        if (memo.ContainsKey(s)) return memo[s];
        if (wordSet.Contains(s)) return true;
        for (int i = 1; i < s.Length; i++) {
            string prefix = s.Substring(0, i);
            if (wordSet.Contains(prefix) && Dfs(s.Substring(i), wordSet, memo)) {
                memo[s] = true;
                return true;
            }
        }
        memo[s] = false;
        return false;
    }
}