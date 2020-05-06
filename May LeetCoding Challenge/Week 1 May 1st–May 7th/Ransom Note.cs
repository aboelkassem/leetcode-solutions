public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] countArr = new int[26];
        
        foreach (var c in magazine.ToCharArray())
        {
            countArr[c - 'a']++;
        }
        
        foreach (var c in ransomNote.ToCharArray())
        {
            if (countArr[c - 'a'] > 0)
                countArr[c - 'a']--;
            else
                return false;
        }
        return true;
    }
}