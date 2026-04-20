/**
 * Definition of Interval:
 * public class Interval {
  *     public int start, end;
   *     public Interval(int start, int end) {
    *         this.start = start;
     *         this.end = end;
      *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (Interval interval in intervals)
            {
                if (dict.ContainsKey(interval.start))
                { return false; }
                dict.Add(interval.start, interval.end);
            }
            var sorted = dict.OrderBy(obj => obj.Key);

            int minStart = -1; 
            int maxEnd = -1;
            foreach (var sort in sorted)
            {
                if(maxEnd == -1 && minStart == -1)
                {
                    minStart = sort.Key;
                    maxEnd = sort.Value;
                }
                else if (sort.Key < maxEnd)
                {
                    if (sort.Value >= minStart)
                    {
                        return false;
                    }
                }
                if (sort.Key < minStart)
                {
                    minStart = sort.Key;
                }
                if (sort.Value > maxEnd)
                {
                    maxEnd = sort.Value;
                }
            }
            return true;
    }
}
