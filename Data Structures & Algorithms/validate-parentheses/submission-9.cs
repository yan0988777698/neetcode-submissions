public class Solution {
    public bool IsValid(string s) {
        Stack<char> charStack = new Stack<char>();

        foreach (char c in s) {
            if (c == '[' || c == '(' || c == '{') {
                charStack.Push(c);
                continue;
            }

            if (charStack.Count == 0)
                return false;

            char open = charStack.Pop();

            if (open == '[' && c != ']') {
                return false;
            };
            if (open == '(' && c != ')') {
                return false;
            };
            if (open == '{' && c != '}') {
                return false;
            }
        }
        return charStack.Count == 0;
    }
}
