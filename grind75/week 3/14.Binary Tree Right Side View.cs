// Link: https://leetcode.com/problems/binary-tree-right-side-view

// Using BFS
// Time:  O(n)
// Space:  O(n)
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
    public IList<int> RightSideView(TreeNode root) {
        var result = new List<int>();

        if (root == null)
            return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            // current level
            var size = queue.Count;
            TreeNode curr = null;
            for (int i = 0; i < size; i++)
            {
                curr = queue.Dequeue();

                if (curr.left != null)
                    queue.Enqueue(curr.left);

                if (curr.right != null)
                    queue.Enqueue(curr.right);
            }
            result.Add(curr.val);
        }
        return result;
    }
}