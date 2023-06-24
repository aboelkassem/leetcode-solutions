// Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock

// Brute-Force
// Time: O(n)
// Space: O(1)

public class Solution {
    public int MaxProfit(int[] prices) {
        var min = prices[0];
        var maxProfit = 0;
        foreach (var today in prices) {
            maxProfit = Math.Max(maxProfit, today-min);
            min = Math.Min(min, today);
        }
        return maxProfit;
    }
}