public class Solution {
    public int MaximumWealth(int[][] accounts) 
    {
        
        int max_wealth = -1;
        

        for(int row = 0; row < accounts.Length; row++)
        {
            int sum = 0;
            for(int col = 0; col < accounts[row].Length; col++)
            {
                sum += accounts[row][col];
            }
            if(sum > max_wealth)
                max_wealth = sum;
        }
        return max_wealth;
    }
}