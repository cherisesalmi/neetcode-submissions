public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
                    int[] result = new int[nums.Length];
            for (int n = 0; n < nums.Length; n++)
            {
                result[n] = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == n)
                    {

                    }
                    else
                    {
                        result[n] *= nums[i];
                    }
                }
            }
            return result;
    }
}
