// Link: https://leetcode.com/problems/3sum

// using two pointers
// Time: O(n^2)
// Space: O(1)

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        // using two pointer approach
        // sort the array
        // iterate over the array
        // for each element, find the two sum of the remaining elements
        // if the sum is 0, add to result
        // if the sum is less than 0, increment left pointer
        // if the sum is greater than 0, decrement right pointer

        Array.Sort(nums);
        var result = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i == 0 || nums[i] != nums[i - 1])
            {
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1])
                            left++;
                        while (left < right && nums[right] == nums[right - 1])
                            right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}