// Link: https://leetcode.com/problems/implement-queue-using-stacks

// Time: O(n)
// Space: O(n)

public class MyQueue
{
    private readonly Stack<int> stack1;

    private readonly Stack<int> stack2;

    public MyQueue()
    {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }

    public void Push(int x)
    {
        stack1.Push(x);
    }

    public int Pop()
    {
        Prepare();
        return stack2.Pop();
    }

    public int Peek()
    {
        Prepare();
        return stack2.Peek();
    }

    public bool Empty()
    {
        return (stack1.Count == 0) && (stack2.Count == 0);
    }

    private void Prepare()
    {
        if (stack2.Count > 0)
        {
            return;
        }

        while (stack1.Count > 0)
        {
            stack2.Push(stack1.Pop());
        }
    }
}