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


// ======= using Two Pointers
// Time: O(n)
// Space: O(1)

public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while (slow != null && fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;  

            if (slow == fast)
                return true;
        }
        return false;
    }
}
