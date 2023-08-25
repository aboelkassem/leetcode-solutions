// Link: https://leetcode.com/problems/majority-element

// Time: O(n)
// Space: O(n)

public class Solution {
    public int MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        var majority = nums.Length / 2;

        // Get the count of each number
        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict.Add(num, 1);
            }
        }

        return dict.FirstOrDefault(x => x.Value > majority).Key;
    }
}