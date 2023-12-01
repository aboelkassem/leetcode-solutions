// Link: https://leetcode.com/problems/search-in-rotated-sorted-array

// Using binary search
// Time: O(log n)
// Space: O(1)

public int Search(int[] nums, int target) {
    int left = 0, right = nums.Length - 1;
    while (left <= right) {
        // int mid = (left + right) / 2;
        var mid = left + (right - left) / 2;

        if (nums[mid] == target)
            return mid;

        if (nums[left] <= nums[mid]) {
            // range left and mid
            if (target > nums[mid] || target < nums[left])
                left = mid + 1;
            else
                right = mid - 1;
        } else {
            // range right and mid
            if (target < nums[mid] && target > nums[right])
                right = mid - 1;
            else
                left = mid + 1;
        }
    }

    return -1;
}
