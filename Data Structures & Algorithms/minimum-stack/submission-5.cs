public class MinStack {
    private Stack<int> intStack;
    private Stack<int> minStack;
    public MinStack() {
        intStack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        intStack.Push(val);
        if(minStack.Count == 0 || val <= minStack.Peek()) minStack.Push(val);
    }
    
    public void Pop() {
        int popped = intStack.Pop();
        if (popped == minStack.Peek()) minStack.Pop();
    }
    
    public int Top() {
        return intStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}