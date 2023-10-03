// Link: https://leetcode.com/problems/contains-duplicate

// Time: O(n)
// Space: O(n)

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var set = new HashSet<int>();
        foreach (var num in nums)
        {
            if (set.Contains(num))
                return true;
                
            set.Add(num);
        }
        return false;
    }
}