// Link: https://leetcode.com/problems/number-of-provinces

// Using DFS
// Time: O(n)
// Space: O(n)

public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        var vis = new bool[isConnected.Length];

        var counter = 0;
        for (int i = 0; i < isConnected.Length; i++)
        {
            // Check Connected Component
            if (!vis[i])
            {
                counter++;
                Traverse(i, ref isConnected, ref vis);
            }
        }

        return counter;
    }

    // Traverse Graph and consider one province (connected component)
    public static void Traverse(int cur, ref int[][] isConnected, ref bool[] vis)
    {
        // DFS Traverse
        vis[cur] = true;
        for (int next = 0; next < isConnected.Length; next++)
        {
            if (isConnected[cur][next] == 1 && !vis[next])
            {
                Traverse(next, ref isConnected, ref vis);
            }
        }
    }
}