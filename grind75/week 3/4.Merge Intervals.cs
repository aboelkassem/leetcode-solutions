// Link: https://leetcode.com/problems/merge-intervals

// Using sorting
// Time: O(nlogn) for sorting
// Space: O(n)
public class Solution {
    public int[][] Merge(int[][] intervals) {
        var result = new List<int[]>();
        Array.Sort(intervals, (arr1, arr2) => arr1[0].CompareTo(arr2[0]));
        var currentInterval = intervals[0];
        result.Add(currentInterval);
        foreach (var interval in intervals)
        {
            var currentEnd = currentInterval[1];
            var nextBegin = interval[0];
            var nextEnd = interval[1];
            if (currentEnd >= nextBegin)
            {
                // overlap
                // merge by extending the end of the current interval
                currentInterval[1] = Math.Max(currentEnd, nextEnd);
            }
            else
            {
                currentInterval = interval;
                result.Add(currentInterval);
            }
        }
        return result.ToArray();
    }
}