/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head) {
             
        Stack<Node> stack = new Stack<Node>();
        Node crnt = head;
        Node stackNode;
        
        while(crnt != null)
        {
            if (crnt.child != null)
            {
                if (crnt.next != null) { stack.Push(crnt.next); }
                crnt.next = crnt.child;
                crnt.child.prev = crnt;
                crnt.child = null;
            }
            else if (stack.Count > 0 && crnt.next == null)
            {
                stackNode = stack.Pop();
                crnt.next = stackNode;
                stackNode.prev = crnt;
            }
            
            crnt = crnt.next;
        }
        
        return head;
    }
}