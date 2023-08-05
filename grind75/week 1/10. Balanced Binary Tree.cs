// Link: https://leetcode.com/problems/balanced-binary-tree

// Time: O(n)
// Space: O(1)

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public bool IsBalanced(TreeNode root) {
        if (root == null)
            return true;

        var leftHeight = GetHeight(root.left);
        var rightHeight = GetHeight(root.right);

        return Math.Abs(leftHeight - rightHeight) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }

    private int GetHeight(TreeNode root)
    {
        if (root == null)
            return 0;
        
        // like just looping/traversal of tree
        return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
    }
} 