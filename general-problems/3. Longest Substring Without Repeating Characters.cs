public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int count = 0, itemCount = 0, start = 0;

        for (int i = 0; i < s.Length; i++)
        {
            itemCount++;
            // check for all substring
            for (int j = start; j < i; j++)
            {
                if (s[i] == s[j])
                {
                    start = j + 1;  // next char
                    itemCount = i - j;
                    break;
                }
            }

            if (itemCount > count) 
                count = itemCount;
        }

        return count;
    }
}