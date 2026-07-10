public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();

        foreach (string token in tokens)
        {
            switch (token)
            {
                case "+":
                {
                    int right = stack.Pop();
                    int left = stack.Pop();
                    stack.Push(left + right);
                    break;
                }

                case "-":
                {
                    int right = stack.Pop();
                    int left = stack.Pop();
                    stack.Push(left - right);
                    break;
                }

                case "*":
                {
                    int right = stack.Pop();
                    int left = stack.Pop();
                    stack.Push(left * right);
                    break;
                }

                case "/":
                {
                    int right = stack.Pop();
                    int left = stack.Pop();
                    stack.Push(left / right);
                    break;
                }

                default:
                    stack.Push(int.Parse(token));
                    break;
            }
        }

        return stack.Pop();
    }
}