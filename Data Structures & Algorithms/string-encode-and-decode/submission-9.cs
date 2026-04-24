public class Solution {
        public string Encode(IList<string> strs)
        {
            if (strs.Count == 0)
            {
                return string.Empty;
            }
            if (strs[0] == string.Empty && strs.Count == 1)
            {
                return "A1#1";
            }

            string result = string.Join("A1#",strs);
            return result;
        }

        public List<string> Decode(string s)
        {
            if (s.Equals("A1#1"))
            {
                return new List<string>() {""};               
            }
            if (s.Length == 0)
            {
                return new List<string>();
            }
            string[] strs = s.Split("A1#");
            return strs.ToList();
        }
    }
