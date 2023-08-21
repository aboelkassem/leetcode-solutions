// Link: https://leetcode.com/problems/reverse-linked-list

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
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null)
            return null;

        var slow = head;
        var fast = head.next;

        while (head != null)
        {
            if (slow == head)
                slow.next = null;

            if (fast == null)
                break;

            var temp = fast.next;
            fast.next = slow;
            slow = fast;
            fast = temp;
        }

        return slow;
    }
}