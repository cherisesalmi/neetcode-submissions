public class Solution {
    public int LongestConsecutive(int[] nums) {
            if(nums.Length == 0){return 0;}
            int amount = 0;
            HashSet<int> values = new HashSet<int>(nums);
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(nums[i]))
                {
                    amount = 0;
                    while (CheckNextInt(nums[i]+amount))
                    {
                        amount++;
                    }
                    map.Add(nums[i], amount);
                }
            }
            
            return map.Values.Max();

            bool CheckNextInt(int val)
            {
                if (values.Contains(val))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
    }
}
