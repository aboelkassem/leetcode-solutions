// Link: https://leetcode.com/problems/intersection-of-two-linked-lists

// brute force
// Time: O(n)
// Space: O(1)
public static ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
    var a = headA;
    var b = headB;
    while (a != b) {
        a = a == null ? headB : a.next;
        b = b == null ? headA : b.next;
    }
    return a;
}

// using stack (some cases not valid because pointer)
// Time: O(n)
// Space: O(n)
public static ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
    if (headA == null || headB == null)
        return null;

    var stackA = new Stack<ListNode>();
    var stackB = new Stack<ListNode>();

    ListNode result = null;

    while (headA != null) {
        stackA.Push(headA);
        headA = headA.next;
    }

    while (headB != null) {
        stackB.Push(headB);
        headB = headB.next;
    }

    while (stackA.Count > 0 && stackB.Count > 0 &&
            stackA.Peek().val == stackB.Peek().val) {
        result = stackA.Peek();
        stackA.Pop();
        stackB.Pop();
    }

    return result;
}
