// Link: https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree

// Using Loop
// Time: O(log n)
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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null)
            return null;

        // special case if root is p or q then its a common ancestor for itself
        if (root.val == p.val || root.val == q.val)
            return root;

        TreeNode curr = root;

        while (curr != null)
        {
            if (p.val > curr.val && q.val > curr.val)
                curr = curr.right;
            else if (p.val < curr.val && q.val < curr.val)
                curr = curr.left;
            else
                return curr;
        }

        return root;
    }
}


// Using Recursion
// Time: O(Height of tree)
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