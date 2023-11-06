// Link: https://leetcode.com/problems/linked-list-cycle-ii

// using fast and slow pointers
// Time: O(n)
// Space: O(1)
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
  public ListNode DetectCycle(ListNode head) {
    if (head == null || head.next == null)
      return null;

    var slow = head;
    var fast = head;

    while (fast != null && fast.next != null) {
      slow = slow.next;
      fast = fast.next.next;

      if (slow == fast)
        break;
    }

    // No cycle
    if (fast == null || fast.next == null)
      return null;

    slow = head;

    // Find the start of the cycle

    while (slow != fast) {
      slow = slow.next;
      fast = fast.next;
    }

    return slow;
  }
}

// using hashset
// Time: O(n)
// Space: O(n)
public class Solution {
  public ListNode DetectCycle(ListNode head) {
    HashSet<ListNode> visited = new();

    while (head is not null) {
      if (visited.Contains(head))
        return head;
      visited.Add(head);
      head = head.next;
    }

    return null;
  }
}
