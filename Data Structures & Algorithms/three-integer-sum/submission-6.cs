public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    for(int k = 1+j; k < nums.Length; k++)
                    {
                        if (nums[i] +  nums[j] + nums[k] == 0)
                        {
                            bool isEqual = false;
                            List<int> newItem = new List<int> { nums[i], nums[j], nums[k] };
                            newItem.Sort();
                            for(int t = 0; t < result.Count; t++)
                            {
                                if (result[t][0] == newItem[0] && result[t][1] == newItem[1] && result[t][2] == newItem[2])
                                {
                                    isEqual = true;
                                    break;
                                }
                            }
                            if (!isEqual)
                            {
                                result.Add(newItem);
                            }
                        }
                    }
                }
            }
            return result;
    }
}
