// Link: https://leetcode.com/problems/ransom-note

// Time: O(n)
// Space: O(n)

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> magzineDictionary = new();
        foreach (var mag in magazine)
        {
            if (magzineDictionary.ContainsKey(mag))
                magzineDictionary[mag]++;
            else
                magzineDictionary[mag] = 1;
        }

        Dictionary<char, int> ransomNoteDictionary = new();
        foreach (var ra in ransomNote)
        {
            if (ransomNoteDictionary.ContainsKey(ra))
                ransomNoteDictionary[ra]++;
            else
                ransomNoteDictionary[ra] = 1;
        }

        foreach (var ranDic in ransomNoteDictionary)
        {
            if (magzineDictionary.ContainsKey(ranDic.Key))
            {
                if (magzineDictionary[ranDic.Key] >= ranDic.Value)
                {
                    ransomNoteDictionary.Remove(ranDic.Key);
                }
            }
        }

        return ransomNoteDictionary.Count == 0;
    }
}