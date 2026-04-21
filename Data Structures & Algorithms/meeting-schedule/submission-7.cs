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
        
            intervals.Sort((A, B) => A.start.CompareTo(B.start));

            int minStart = -1; 
            int maxEnd = -1;
            foreach (var sort in intervals)
            {
                if(maxEnd == -1 && minStart == -1)
                {
                    minStart = sort.start;
                    maxEnd = sort.end;
                }
                else if (sort.start < maxEnd)
                {
                    if (sort.end >= minStart)
                    {
                        return false;
                    }
                }
                if (sort.start < minStart)
                {
                    minStart = sort.start;
                }
                if (sort.end > maxEnd)
                {
                    maxEnd = sort.end;
                }
            }
            return true;
    }
}
