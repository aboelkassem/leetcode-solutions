// Link: https://leetcode.com/problems/invert-binary-tree

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
    public TreeNode InvertTree(TreeNode root) {
        // Exception for empty tree
        if (root == null)
            return root;

        var result = new TreeNode(root.val);

        if (root.left != null)
            result.right = InvertTree(root.left);

        if (root.right != null)
            result.left = InvertTree(root.right);
        
        return result;
    }
}