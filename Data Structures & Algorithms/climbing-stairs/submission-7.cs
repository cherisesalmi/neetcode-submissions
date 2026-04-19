public class Solution {
    public int ClimbStairs(int n) {
                   int count = 0;

           if (n == 0)
           {
               count = 0;
           }
           else if (n == 1)
           {
               count = 1;
           }
           else if (n == 2)
           {
               count = 2;
           }else if (n == 3)
           {
               count = 3;
           }
           int pre = 2;
           int curr = 3;
           for (int i = 4; i <= n; i++)
           {
               count =+ pre + curr;
               pre = curr;
               curr = count;
           }
           return count;
    }
}
