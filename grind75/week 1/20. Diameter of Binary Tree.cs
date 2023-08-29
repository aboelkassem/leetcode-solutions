// Link: https://leetcode.com/problems/diameter-of-binary-tree

// Time: O(n)
// Space: O(1)
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
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root == null)
            return 0;

        var leftHeight = Height(root.left);
        var rightHeight = Height(root.right);

        var leftDiameter = DiameterOfBinaryTree(root.left);
        var rightDiameter = DiameterOfBinaryTree(root.right);

        return Math.Max(leftHeight + rightHeight, Math.Max(leftDiameter, rightDiameter));
    }

    public static int Height(TreeNode root)
    {
        if (root == null)
            return 0;

        return 1 + Math.Max(Height(root.left), Height(root.right));
    }
}