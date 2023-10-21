// Link: https://leetcode.com/problems/insert-interval

// Using brute force
// Time: O(n)
// Space: O(n)
public class Solution {
        public int[][] Insert(int[][] intervals, int[] newInterval) {
            if (intervals.Length == 0)
                return new int[][] { newInterval };

            var result = new List<int[]>();
            var newStart = newInterval[0];
            var newEnd = newInterval[1];
            int minStart = int.MaxValue; int maxEnd = int.MinValue;
            bool isInterveralBetweenIntervals = false;

            for (int i = 0; i < intervals.Length; i++)
            {
                var start = intervals[i][0];
                var end = intervals[i][1];

                if (end >= newStart && start <= newEnd)
                {
                    // overrlaped
                    minStart = Math.Min(start, minStart);
                    minStart = Math.Min(newStart, minStart);
                    maxEnd = Math.Max(end, maxEnd);
                    maxEnd = Math.Max(newEnd, maxEnd);

                    isInterveralBetweenIntervals = true;
                }
                else
                {
                    // insert non overrlapped
                    result.Add(intervals[i]);
                }
            }

            if (minStart != int.MaxValue && maxEnd != int.MinValue)
                result.Add(new int[] { minStart, maxEnd });

            if (!isInterveralBetweenIntervals)
                result.Add(newInterval);

            return result.OrderBy(x => x[0]).ToArray();
        }
}