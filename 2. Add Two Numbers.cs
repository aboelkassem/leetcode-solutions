/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummyHead = new ListNode(0);
        ListNode l3 = dummyHead;
        int carry = 0;

        while(l1 != null || l2 != null)
        {
            // make sure that value is not null, or make a fake number 0 to add
            int l1_val = (l1 != null) ? l1.val : 0;
            int l2_val = (l2 != null) ? l2.val : 0;

            int current_Sum = l1_val + l2_val + carry;
            carry = current_Sum / 10;
            int last_Digit = current_Sum % 10;

            ListNode newNode = new ListNode(last_Digit);
            l3.next = newNode;

            // traverse to next
            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;
            l3 = l3.next;
        }

        if (carry > 0)
        {
            ListNode newNode = new ListNode(carry);
            l3.next = newNode;
        }
        return dummyHead.next;
    }
}