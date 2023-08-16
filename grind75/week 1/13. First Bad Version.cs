// Link: https://leetcode.com/problems/first-bad-version

// Time: O(log n)
// Space: O(1)
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int min = 0, max = n;
        int result = 0;
        while(min <= max)
        {
            // Here we need to use safe formula for calculation middlePointer
            // instead of "int middle = (left + right) / 2
            // to avoid int number overflow
            int mid = min + (max-min)/2;
            if(IsBadVersion(mid))
            {
                result = mid;
                max = mid -1;
            }
            else
                min = mid +1;
        }

        return result;
    }
}