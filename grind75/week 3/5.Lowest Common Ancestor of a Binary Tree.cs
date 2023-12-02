// Link: https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree

// Using DFS
// Time: O(n)
// Space: O(n)
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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null)
            return null;

        // special case if root is p or q then its a common ancestor for itself
        if (root.val == p.val || root.val == q.val)
            return root;

        var left = LowestCommonAncestor(root.left, p, q);
        var right = LowestCommonAncestor(root.right, p, q);

        if (left != null && right != null)
            return root;

        return left ?? right;
    }
}