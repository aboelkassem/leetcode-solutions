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
    public int WidthOfBinaryTree(TreeNode root) {
        if (root == null) { return 0; }
        
        Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
        nodeQueue.Enqueue(root);
        
        Queue<int> idQueue = new Queue<int>();
        idQueue.Enqueue(1);
        
        int size = 0;
        int maxWidth = 0;
        TreeNode crnt;
        int id;
        int? first;
        int? last=null;
        int width = 0;
        
        while(nodeQueue.Count > 0)
        {
            size = nodeQueue.Count;
            first = null;
            
            while(size > 0)
            {
                size--;
                crnt = nodeQueue.Dequeue();
                id = idQueue.Dequeue();
                
                if (first == null) { first = id; }
                last = id;
                
                if (crnt.left != null)
                {
                    nodeQueue.Enqueue(crnt.left);
                    idQueue.Enqueue((int)last << 1);
                }
                
                 if (crnt.right != null)
                {
                    nodeQueue.Enqueue(crnt.right);
                    idQueue.Enqueue((int)last << 1|1);
                }
            }
            
            if (first != null)
            {
                width = (int)last - (int)first + 1;
                if (width > maxWidth) { maxWidth = width; }
            }
        }
        
        return maxWidth;
    }
}