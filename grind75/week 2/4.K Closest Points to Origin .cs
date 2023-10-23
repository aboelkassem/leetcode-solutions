// Link: https://leetcode.com/problems/k-closest-points-to-origin

// Time: O(n)
// Space: O(n)
public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[], double>(k);
        foreach (var p in points)
        {
            var distance = Math.Sqrt((Math.Pow(p[0] - 0, 2) + Math.Pow(p[1] - 0, 2)));
            //var distance = (p[0] * p[0] + p[1] * p[1]);
            pq.Enqueue(p, distance);
        }
        var res = new int[k][];
        for (int i = 0; i < k; i++)
            res[i] = pq.Dequeue();
        return res;
    }
}