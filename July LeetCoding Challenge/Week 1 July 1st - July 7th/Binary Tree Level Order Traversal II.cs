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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        IList<int> intermediate = new List<int>();
        if (root == null)
        {
            return result;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        queue.Enqueue(null);
        while (queue.Count != 0)
        {
            TreeNode temp = queue.Dequeue();
            if (temp != null)
            {
                intermediate.Add(temp.val);
                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
            }
            else if (temp == null)
            {
                if (queue.Count > 0)
                {
                    queue.Enqueue(null);
                    result.Add(intermediate);
                    intermediate = new List<int>();
                }
            }
        }
        result.Add(intermediate);
        IList<IList<int>> final = new List<IList<int>>();
        for (int i = result.Count - 1; i >= 0; i--)
        {
            final.Add(result[i]);
        }
        return final;
    }
}