public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
            List<List<int>> result = new List<List<int>>();
            HashSet<Tuple<int,int,int>> set = new HashSet<Tuple<int,int,int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    for(int k = 1+j; k < nums.Length; k++)
                    {
                        if (nums[i] +  nums[j] + nums[k] == 0)
                        {
                           var newItem= Tuple.Create(nums[i], nums[j], nums[k]);
                            set.Add(newItem);
                        }
                    }
                }
            }
            foreach (var item in set)
            {
                result.Add(new List<int> { item.Item1, item.Item2, item.Item3 });
            }
            return result;
    }
}
