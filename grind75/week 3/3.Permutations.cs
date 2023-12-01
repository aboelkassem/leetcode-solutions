// Link: https://leetcode.com/problems/permutations

// Using backtracking
// Time: O(n!) - total permutations count
// Space: O(n) - max depth of recursion stack
public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        var visited = new bool[nums.Length];
        Backtrack(nums, visited, new List<int>(), result);
        return result;
    }

    private void Backtrack(int[] nums, bool[] visited, List<int> current, List<IList<int>> result)
    {
        if (current.Count == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (visited[i])
                continue;

            visited[i] = true;
            current.Add(nums[i]);
            Backtrack(nums, visited, current, result);
            current.RemoveAt(current.Count - 1);
            visited[i] = false;
        }
    }
}