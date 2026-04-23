public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
                   List<List<string>> result = new List<List<string>>();
           bool added = false;
           foreach (string str in strs)
           {
               for (int i = 0; i < result.Count; i++)
               {
                   if(str.Length == result[i][0].Length)
                   {
                       char[] strChar = str.ToCharArray();
                       char[] strResult = result[i][0].ToCharArray();
                       Array.Sort(strChar);
                       Array.Sort(strResult);
                       if (strChar.SequenceEqual(strResult))
                       {
                           result[i].Add(str);
                           added = true;
                           break;
                       }
                   }
               }
               if (!added)
               {
                   result.Add(new List<string>());
                   result[result.Count - 1].Add(str);
               }
               added = false;
           }
           return result;
                    
    }
}
