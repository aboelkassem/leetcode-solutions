// Link: https://leetcode.com/problems/binary-tree-level-order-traversal

// using BFS
// Time: O(n)
// Space: O(n)
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
  public IList<IList<int>> LevelOrder(TreeNode root) {
    // using BFS
    var result = new List<IList<int>>();

    if (root == null)
      return result;

    var queue = new Queue<TreeNode>();
    queue.Enqueue(root);
    while (queue.Count > 0) {
      // size = queue.Count is current level
      var size = queue.Count;
      var list = new List<int>();
      for (int i = 0; i < size; i++) {
        var cur = queue.Dequeue();

        list.Add(cur.val); // always will be the leftmost node

        if (cur.left != null)
          queue.Enqueue(cur.left);

        if (cur.right != null)
          queue.Enqueue(cur.right);
      }

      result.Add(list);
    }

    return result;
  }
}