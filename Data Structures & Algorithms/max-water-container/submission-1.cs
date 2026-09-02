public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0;
        int l = 0 , r = heights.Length - 1;

        while(l < r){
            int area = (Math.Min(heights[l], heights[r]) * (r-l));
            res = Math.Max(area, res);

            if(heights[l] <= heights[r]){
                l++;
            } else{
                r--;
            }
        }

        return res;

        // List<int> bestScore = new List<int>();
        // for(int i = 0; i < heights.Length; i++){
        //     for(int j = i + 1; j < heights.Length; j++){
        //         bestScore.Add(Math.Min(heights[i], heights[j]) * (j-i));
        //     }
        // }

        // return bestScore.Max();
    }
}
