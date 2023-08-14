// Link: https://leetcode.com/problems/linked-list-cycle

// ======= using HashSet
// Time: O(n)
// Space: O(n)

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> visited = new HashSet<ListNode>();
        while (head != null)
        {
            if (visited.Contains(head))
                return true;

            visited.Add(head);
            head = head.next;
        }
        return false;
    }
}