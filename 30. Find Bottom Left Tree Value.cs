// Link: https://leetcode.com/problems/find-bottom-left-tree-value

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
    public int FindBottomLeftValue(TreeNode root) {
        // BFS
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var result = root.val;
        while (queue.Count > 0)
        {
            // size = queue.Count is current level
            var size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var cur = queue.Dequeue();
                if (i == 0) // first element (leftmost node) in current level
                    result = cur.val; // always will be the leftmost node

                if (cur.left != null)
                    queue.Enqueue(cur.left);
                if (cur.right != null)
                    queue.Enqueue(cur.right);
            }
        }
        // get last element
        return result;
    }
}