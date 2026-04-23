public class Solution {
    public int[] CountBits(int n) {
        List<int> result = new List<int>();
        string binary;

        for (int i = 0; i <= n; i++)
        {
            binary = Convert.ToString(i, 2);
            int count = 0;
            for (int j = 0; j < binary.Length; j++)
            {
                if (binary[j] == '1')
                {
                    count++;
                }
            }
            result.Add(count);
        }
        return result.ToArray();
    }
}
