// Link: https://leetcode.com/problems/climbing-stairs

// Time: O(n)
// Space: O(1)

public class Solution {
    public int ClimbStairs(int n) {
        var one = 1;
        var two = 1
        // how many problems we actually need to be executed is n-1
        for (int i = 0; i < n -1 ; i++)
        {
            var temp = one;
                // shift the two values
            one = one + two;
            two = temp;
        }
        return one;
    }
}