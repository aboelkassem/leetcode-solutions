// Link: https://leetcode.com/problems/unique-paths

// Using Recursion
// Time:  O(2^n)
// Space:  O(1)
public class Solution {
    public int UniquePaths(int m, int n) {
        var ans = 0;
        void Search(int r, int c)
        {
            // base case
            // outbounded
            if (r > m || c > n )
                return;

            // reaches bottom-right corner
            if (r == m-1 && c == n - 1)
            {
                ans++;
                return;
            }

            Search(r + 1, c);
            Search(r, c+1);
        }

        Search(0, 0);
        return ans;
    }
}

// Using DP
// Time:  O(n*m)
// Space:  O(n*m)
public class Solution {
    public int UniquePaths(int m, int n) {
        var dp = new int[m][];
        for (int i = 0; i < m; i++)
        {
            dp[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                dp[i][j] = 1;
            }
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
            }
        }

        return dp[m - 1][n - 1];
    }
}