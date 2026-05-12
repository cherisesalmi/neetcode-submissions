public class Solution {
    public int MaxArea(int[] heights) {
                        int maxArea = 0;
            int leftPointer = 0;
            int rightPointer = heights.Length - 1;
            int currentArea = 0;

            while (leftPointer < rightPointer)
            {

                if (heights[leftPointer] > heights[rightPointer])
                {
                    currentArea = heights[rightPointer] * (rightPointer - leftPointer);
                    rightPointer--;
                }
                else
                {
                    currentArea = heights[leftPointer] * (rightPointer - leftPointer);
                    leftPointer++;
                }
                if (maxArea < currentArea)
                {
                    maxArea = currentArea;
                }
            }
            return maxArea;    
                    
    }
}
