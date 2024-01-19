public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i = 0;
        foreach (int num in nums)
            if (nums[i] != num)
                nums[++i] = num;

        return nums.Length != 0 ? i + 1 : 0;
    }
}