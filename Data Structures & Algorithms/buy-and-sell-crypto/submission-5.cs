public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length <= 1) return 0;

        int previous = prices[0];
        int maxProfit = 0;
        for(int i = 0; i < prices.Length; i++){

            if(i == 0) continue;

            if(prices[i] < previous) previous = prices[i];
            int currentProfit = prices[i] - previous;
            if(currentProfit > maxProfit){
                maxProfit = currentProfit;
            }
        }
        return maxProfit;
    }
}
