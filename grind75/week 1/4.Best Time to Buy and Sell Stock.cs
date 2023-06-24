// Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock

// Brute-Force

// First Try (will not work)
// Throw an an exception of Time Limit Exceeded Error 
// Time: O(n^2)
// Space: O(1)

public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i; j < prices.Length; j++)
            {
                var profit = prices[j] - prices[i];
                if (profit > 0 && profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
        }
        
        return maxProfit;
    }
}

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