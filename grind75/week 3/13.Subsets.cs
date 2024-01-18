// Link: https://leetcode.com/problems/subsets

// Using brute force
// Time:  O(2^n)
// Space:  O(n)
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> subsets = new List<IList<int>>
				{
				    new List<int>()
				};
				
				for (int i = 0; i < nums.Length; i++)
				{
						// previous subsets
				    int count = subsets.Count;
				    for (int j = 0; j < count; j++)
				    {
								// create a new subset from the existing subset and add the current element to it
				        var temp = subsets[j].ToList();
				        temp.Add(nums[i]);
				        subsets.Add(temp);
				    }
				}
				return subsets;
    }
}

// Using backtracking
// Time:  O(2^n) since you explore all possible subsets, and for each subset, you perform constant time operations to add or remove elements from the subset list.
// Space:  O(n)
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();

        Search(nums, 0, new List<int>(10), result);

        return result;
    }

    private void Search(int[] nums, int index, IList<int> temp, IList<IList<int>> result)
    {
        result.Add(temp.ToArray());

        for (int i = index; i < nums.Length; i++)
        {
            temp.Add(nums[i]);
            Search(nums, i + 1, temp, result);
            temp.RemoveAt(temp.Count - 1);
        }
    }
}