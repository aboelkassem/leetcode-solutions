// Link: https://leetcode.com/problems/min-stack

// Time: O(1)
// Space: O(n)
public class MinStack {
    public Stack<int> _stack { get; set; }
    public Stack<int> minStack { get; set; }

    public MinStack()
    {
        _stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        _stack.Push(val);
        // always store the min value in the minStack
        if (minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
    }

    public void Pop()
    {
        if (_stack.Count == 0)
            return;

        var val = _stack.Pop();

        // to remove it from the minStack as well
        if (val == minStack.Peek())
            minStack.Pop();
    }

    public int Top()
    {
        return _stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */