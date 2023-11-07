// Link: https://leetcode.com/problems/coin-change

// using DP
// Time: O(S*n) where S is the amount, n is denomination count
// Space: O(S)

public int CoinChange(int[] coins, int amount)
{
    // build dp array
    var dp = new int[amount + 1];
    Array.Fill(dp, int.MaxValue - 1);
    
    // base case
    dp[0] = 0;

    for (int i = 0; i < dp.Length; i++)
    {
        for (int j = 0; j < coins.Length; j++)
        {
            if (coins[j] <= i)
            {
                dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
            }
        }
    }
    return dp[amount] > amount ? -1 : dp[amount];
}