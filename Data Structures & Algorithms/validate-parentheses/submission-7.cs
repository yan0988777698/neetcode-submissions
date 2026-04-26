public class Solution {
    public bool IsValid(string s) {
        Stack<char> charStack = new Stack<char>();
        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            if (c == '[' || c == '(' || c == '{') {
                charStack.Push(c);
            } else {

                if(charStack.Count == 0) return false;
                char another = charStack.Pop();
                if (another == '[' && c != ']') {
                    return false;
                };
                if (another == '(' && c != ')') {
                    return false;
                };
                if (another == '{' && c != '}') {
                    return false;
                }
            };
        }
        return charStack.Count == 0 ? true : false;
    }
}
