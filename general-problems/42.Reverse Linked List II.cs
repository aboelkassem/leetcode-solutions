// Link: https://leetcode.com/problems/reverse-linked-list-ii

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
  public ListNode ReverseBetween(ListNode head, int left, int right) {
    ListNode ret = head;
    if (left == right)
      return ret;

    ListNode prev = null;
    ListNode next = null;
    // start and end of list to be reversed
    ListNode start = null;
    ListNode end = null;
    int count = 1;
    while (head != null) {
      if (count == left - 1)
        prev = head;
      else if (count == left)
        start = head;
      else if (count == right)
        end = head;
      else if (count == right + 1) {
        next = head;
        break;
      }

      head = head.next;
      count++;
    }

    Reverse(ref start, ref end);

    // connect the reversed list to the previous and next nodes
    if (prev != null)
      prev.next = end;

    start.next = next;

    // return ret;
    if (left == 1)
      return end;
    else
      return ret;
  }

  private void Reverse(ref ListNode start, ref ListNode end) {
    ListNode p1 = start;
    ListNode p2 = start.next;
    while (p1 != end) {
      ListNode temp = p2.next;
      p2.next = p1;
      p1 = p2;
      p2 = temp;
    }
  }
}
