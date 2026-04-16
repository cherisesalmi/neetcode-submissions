public class Solution {
    public bool IsValid(string s) {
            if (s == null) {
                return false;
            }
            else if (s.Length == 0) {
                return true;
            }
            else if(s.Length % 2 != 0) {
                return false;
            }
            else{
                Stack<char> stack = new Stack<char>();

                Dictionary<char, char> dictionary = new Dictionary<char, char> {
                    {'(',')'},
                    {'{','}'},
                    {'[',']'}
                    };

                stack.Push(s[0]);

                for (int i = 1; i < s.Length; i++) {
                    char c;
                    if(stack.Count == 0){
                        stack.Push(s[i]);
                    }
                    else if(dictionary.TryGetValue(stack.Peek(), out c)){
                        if(c == s[i])
                            stack.Pop();
                        else{
                        stack.Push(s[i]);
                        }
                    }
                    
                }
                if (stack.Count == 0) {
                    return true;
                }
                return false;
            }
    }
}
