// Link: https://leetcode.com/problems/validate-binary-search-tree

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
    public bool IsValidBST(TreeNode root) {
        // Using In-order traversal
        var orderedList = new List<int>();
        InOrderTraversal(root, ref orderedList);

        for (int i = 1; i <= orderedList.Count - 1; i++)
        {
            if (orderedList[i-1] >= orderedList[i])
                return false;
        }
        return true;
    }

    private static void InOrderTraversal(TreeNode root, ref List<int> ordered)
    {
        if (root == null)
            return;
        InOrderTraversal(root.left, ref ordered);
        ordered.Add(root.val);
        InOrderTraversal(root.right, ref ordered);
    }
}