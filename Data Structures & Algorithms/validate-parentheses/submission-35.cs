public class Solution {
    public bool IsValid(string s) {

        Stack<char> stack = new Stack<char>();

        foreach(char i in s) 
        {
            switch (i)
            {
                case '}':
                    if (stack.Count != 0 && stack.Peek() == '{') stack.Pop();
                    else return false;
                    break;
                case ')':
                    if (stack.Count != 0 && stack.Peek() == '(') stack.Pop();
                    else return false;
                    break;
                case ']':
                    if ( stack.Count != 0 && stack.Peek() == '[' ) {stack.Pop();}
                    else return false;
                    break;
                default:
                    stack.Push(i);
                    break;
            }
        }
        return stack.Count == 0;
    }
}
