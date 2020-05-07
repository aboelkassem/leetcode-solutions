public class Solution {
    public int MajorityElement(int[] nums) {
       return nums.GroupBy(num => num)
                .First(group => group.Count() > nums.Length / 2)
                .Key;
    }
}