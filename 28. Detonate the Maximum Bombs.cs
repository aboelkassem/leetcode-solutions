// Link: https://leetcode.com/problems/detonate-the-maximum-bombs

// Using DFS
public class Solution {
    public int MaximumDetonation(int[][] bombs) {
        var adjacencyList = buildBombsNetwork(ref bombs);
        var maxDetonation = 0;

        for (int i = 0; i < bombs.Length; i++)
        {
            // Get The max detontations by compare each visited nodes
            var visited = new bool[bombs.Length];
            detonate(i, ref adjacencyList, ref visited);
            var count = 0;
            for (int bomb = 0; bomb < visited.Length; bomb++)
            {
                count += visited[bomb] ? 1 : 0;
            }
            maxDetonation = Math.Max(maxDetonation, count);
        }

        return maxDetonation;
    }


    public static int[,] buildBombsNetwork(ref int[][] bombs)
    {
        var adjacencyList = new int[bombs.Length, bombs.Length];

        for (int src = 0; src < bombs.Length; src++)
        {
            var x1 = bombs[src][0];
            var y1 = bombs[src][1];
            var r1 = bombs[src][2];

            for (int dst = 0; dst < bombs.Length; dst++)
            {
                if (src != dst)
                {
                    var x2 = bombs[dst][0];
                    var y2 = bombs[dst][1];
                    var r2 = bombs[dst][2];

                    // dist^2 = width^2 + hight^2
                    // width = x2 - x1
                    // hight = y2 - y1

                    // if r1 >= dis -> edge and can trigger/effect the bomb

                    var width = Math.Pow(x2 - x1, 2);
                    var hight = Math.Pow(y2 - y1, 2);
                    var dist = Math.Sqrt(width + hight);

                    if (r1 >= dist)
                    {
                        adjacencyList[src, dst] = 1;
                    }
                }
            }
        }
        return adjacencyList;
    }
    public static void detonate(int cur, ref int[,] adj, ref bool[] visited)
    {
        // DFS Traverse
        visited[cur] = true;
        for (int bomb = 0; bomb < adj.GetLength(0); bomb++)
        {
            if (adj[cur, bomb] == 1 && !visited[bomb])
                detonate(bomb, ref adj, ref visited);
        }
    }
}