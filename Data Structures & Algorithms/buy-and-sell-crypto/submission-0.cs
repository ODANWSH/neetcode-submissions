public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int right = 1;
        int maxP= 0;

        while(right < prices.Length){
            if(prices[left] < prices[right]){
                int profit = prices[right] - prices[left];
                maxP = Math.Max(maxP, profit);
            } else {
                left = right;
            }
            right += 1;
        }

        return maxP;
    }
}
