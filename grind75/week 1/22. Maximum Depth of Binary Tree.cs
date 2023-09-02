// Link: https://leetcode.com/problems/maximum-depth-of-binary-tree

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
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;
        else
        {
            int leftHeight = MaxDepth(root.left);
            int rightHeight = MaxDepth(root.right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}