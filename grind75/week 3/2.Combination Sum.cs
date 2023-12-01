// Link: https://leetcode.com/problems/combination-sum

// Using backtracking
// Time: O(2^N)
// Space: O(2^N)
public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var result = new List<IList<int>>();
        Search(candidates, target, 0, 0, new List<int>(), result);
        return result;
    }

    private void Search(int[] candidates, int target, int index, int sum, IList<int> temp, IList<IList<int>> result)
    {
        if (sum == target)
        {
            result.Add(temp.ToArray());
            return;
        }

        while (sum < target && index < candidates.Length)
        {
            temp.Add(candidates[index]);

            Search(candidates, target, index, sum + candidates[index], temp, result);

            temp.RemoveAt(temp.Count - 1);
            index++;
        }
    }
}