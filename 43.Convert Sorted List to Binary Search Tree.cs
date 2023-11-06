// Link: https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree

// Time: O(n)
// Space: O(n)
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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
  public TreeNode SortedListToBST(ListNode head) {
    // instead of traversing each time to get middle element,
    // we can use list to get the middle element in O(1)
    var list = new List<int>();
    while (head != null) {
      list.Add(head.val);
      head = head.next;
    }

    TreeNode bisect(int start, int end) {
      if (start > end)
        return null;

      var mid = (start + end) / 2;
      var node = new TreeNode(list[mid]);
      node.left = bisect(start, mid - 1);
      node.right = bisect(mid + 1, end);
      return node;
    }

    return bisect(0, list.Count - 1);
  }
}