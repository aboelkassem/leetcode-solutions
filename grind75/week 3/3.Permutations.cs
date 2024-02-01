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

  private void Backtrack(int[] nums, bool[] visited, List<int> current,
                         List<IList<int>> result) {
    if (current.Count == nums.Length) {
      result.Add(new List<int>(current));
      return;
    }

    for (int i = 0; i < nums.Length; i++) {
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

// Using BFS
// Time: O(n!) - total permutations count
// Space: O(n)
public class Solution {
  public IList<IList<int>> Permute(int[] nums) {
    var result = new List<IList<int>>();
    var queue = new Queue<List<int>>();
    queue.Enqueue(new List<int>());

    for (int i = 0; i < nums.Length; i++) {
      int size = queue.Count;
      for (int j = 0; j < size; j++) {
        var curr = queue.Dequeue();           // get latest list
        for (int k = 0; k <= curr.Count; k++) // add it into every single index
        {
          var temp = new List<int>(curr); // take a copy
          temp.Insert(k, nums[i]);        // insert at index
          queue.Enqueue(temp);
        }
      }
    }

    while (queue.Count > 0)
      result.Add(queue.Dequeue());

    return result;
  }
}
