// Link: https://leetcode.com/problems/maximum-subarray

// Using brute force
// Time: O(n)
// Space: O(1)

public class Solution {
    public int MaxSubArray(int[] nums) {
        // using brute force
        var max = nums[0];
        var sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (sum > max)
            {
                max = sum;
            }
            if (sum < 0)
            {
                sum = 0;
            }
        }
        return max;
    }
}

// Using Divide and Conquer
// Time: O(n log n)
// Space: O(log n)
public class Solution {
    public int MaxSubArray(int[] nums) {
        // using divide and conquer
        return MaxSubArray(nums, 0, nums.Length - 1);
    }

    static int MaxSubArray(int[] nums, int left, int right)
    {
        if (left == right)
        {
            return nums[left];
        }

        int mid = (left + right) / 2;
        int leftSum = MaxSubArray(nums, left, mid);
        int rightSum = MaxSubArray(nums, mid + 1, right);
        int crossSum = CrossSum(nums, left, right, mid);

        return Math.Max(Math.Max(leftSum, rightSum), crossSum);
    }

    static int CrossSum(int[] nums, int left, int right, int mid)
    {
        if (left == right)
        {
            return nums[left];
        }

        int leftSubSum = int.MinValue;
        int currSum = 0;
        for (int i = mid; i > left - 1; --i)
        {
            currSum += nums[i];
            leftSubSum = Math.Max(leftSubSum, currSum);
        }

        int rightSubSum = int.MinValue;
        currSum = 0;
        for (int i = mid + 1; i < right + 1; ++i)
        {
            currSum += nums[i];
            rightSubSum = Math.Max(rightSubSum, currSum);
        }

        return leftSubSum + rightSubSum;
    }
}

// Using Kadane's algorithm
// Time: O(n)
// Space: O(1)

public class Solution {
    public int MaxSubArray(int[] nums) {
        // using Kadane's algorithm

        var maxSoFar = nums[0];
        var maxEndingHere = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            maxEndingHere = Math.Max(maxEndingHere + nums[i], nums[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }
}