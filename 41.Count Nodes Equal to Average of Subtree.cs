// Link: https://leetcode.com/problems/count-nodes-equal-to-average-of-subtree

// Using DFS Recursive
// Time: O(n)
// Space: O(h) = height, worst cases if not balanced O(n) else O(log n)

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
    public int AverageOfSubtree(TreeNode root) {
        var result = 0;
        AverageOfSubtreeDfs(root, ref result);
        return result;
    }

    (int sum, int count) AverageOfSubtreeDfs(TreeNode node, ref int result)
    {
        if (node == null)
            return (sum: 0, count: 0);

        var (sumL, countL) = AverageOfSubtreeDfs(node.left, ref result);
        var (sumR, countR) = AverageOfSubtreeDfs(node.right, ref result);

        var sumN = sumL + sumR + node.val;
        var countN = countL + countR + 1;
        var avgN = sumN / countN;

        if (avgN == node.val)
            result++;

        return (sumN, countN);
    }
}

// Using DFS Stack
// Time: O(n)
// Space: O(n)

public static int AverageOfSubtree(TreeNode root)
{
    Stack<TreeNode> stack = new(new TreeNode[] { root });
    Dictionary<TreeNode, int[]> dict = new();
    int count = 0;

    while (stack.Count > 0)
    {
        TreeNode node = stack.Peek();

        if (node.left != null && !dict.ContainsKey(node.left))
        {
            stack.Push(node.left);
            continue;
        }

        if (node.right != null && !dict.ContainsKey(node.right))
        {
            stack.Push(node.right);
            continue;
        }

        int leftSum = 0, numOfLeftNodes = 0, rightSum = 0, numOfRightNodes = 0;

        if (node.left != null)
        {
            leftSum = dict[node.left][0];
            numOfLeftNodes = dict[node.left][1];
            dict.Remove(node.left);
        }

        if (node.right != null)
        {
            rightSum = dict[node.right][0];
            numOfRightNodes = dict[node.right][1];
            dict.Remove(node.right);
        }

        dict[node] = new int[] { node.val + leftSum + rightSum, 1 + numOfLeftNodes + numOfRightNodes };

        if ((dict[node][0] / dict[node][1]) == node.val)
            count++;

        stack.Pop();
    }

    return count;
}