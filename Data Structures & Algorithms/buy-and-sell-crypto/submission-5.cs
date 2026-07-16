public class Solution {
    public int MaxProfit(int[] prices) {
        List<int> bucket = new List<int> {};
        int biggest = 0;
       for (int i = 0; i < prices.Length; i++) {
        // list.Add(0);

        int idx = i + 1;
        while (idx < prices.Length) {
            
            int delta = prices[idx] - prices[i];
            if (biggest < delta) {
               biggest = delta; 
            }
            idx++;
        }
       }
       return biggest;

    }
}
