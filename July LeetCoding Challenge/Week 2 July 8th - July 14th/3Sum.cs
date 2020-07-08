public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        Array.Sort(nums);

        var ans = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i - 1] == nums[i])
                continue;

            int l = i + 1;
            int r = nums.Length - 1;
            while (l < r)
            {
                int sum = nums[i] + nums[l] + nums[r];
                if (sum == 0)
                {
                    ans.Add(new List<int>() { nums[i], nums[l], nums[r] });
                    while (l < r && nums[l + 1] == nums[l])
                        l++;
                    while (l < r && nums[r - 1] == nums[r])
                        r--;
                    l++;
                    r--;
                }
                else if (sum > 0)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }
        }

        return ans;
    }
}