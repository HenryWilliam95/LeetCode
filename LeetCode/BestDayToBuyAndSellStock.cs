namespace LeetCode
{
    internal class BestDayToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            var buy = prices[0];
            var profit = 0;

            prices[0] = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if(buy > prices[i])
                {
                    buy = prices[i];
                    prices[i] = 0;
                }
                else
                {
                    profit = Math.Max(prices[i] - buy, profit);
                }
            }

            return profit;
        }
    }
}
