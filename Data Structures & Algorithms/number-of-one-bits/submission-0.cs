public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;
        string nString = Convert.ToString(n, 2);
        for (int i = 0; i < nString.Length; i++)
            {
                if (nString[i] == '1')
                {
                    count++;
                }
            }
            return count;                   
    }
}