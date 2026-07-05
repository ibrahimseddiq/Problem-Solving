public class Solution {
    public bool IsValid(string s) {
        char[] arr = new char[s.Length];
        int top = 0;

        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                arr[top] = c;
                top++;
            } 
            else {
                if (top == 0) return false;

                char lastOpen = arr[top - 1];

                if ((c == ')' && lastOpen == '(') ||
                    (c == '}' && lastOpen == '{') ||
                    (c == ']' && lastOpen == '[')) {
                    top--;
                } else {
                    return false; 
                }
            }
        }
        return top == 0;
    }
}