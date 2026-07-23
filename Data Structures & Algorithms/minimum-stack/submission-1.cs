public class MinStack {

    Stack<int> stack;
    Stack<int> lowStack;
    int lowest = int.MaxValue;


    public MinStack() {
        stack = new Stack<int>();
        lowStack = new Stack<int>();
        lowStack.Push(lowest);
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (val <= lowStack.Peek()) {
            lowStack.Push(val);
        }
    }
    
    public void Pop() {
        if (stack.Pop() == lowStack.Peek()) {
            lowStack.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
       return lowStack.Peek();
    }
}
