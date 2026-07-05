public class Solution {
    public int DiagonalSum(int[][] mat) 
    {
        int primarySummition = 0;
        int SecondrySummition = 0;

        int numsOfColumns = mat[0].Length;

        if(mat.Length != numsOfColumns)
            return -1;

        else if(mat.Length == 1)
            return mat[0][0];

        else
        {
            int midOfMatrix = 0;
            
            if(mat.Length % 2 != 0) // Number of rows not even
            {
                midOfMatrix = mat.Length / 2;
                int repeatedElement = mat[midOfMatrix][midOfMatrix]; // Center of Diagonal
                primarySummition += repeatedElement;
            }
            for(int row = 0; row < mat.Length; row++)
            {
                
                if(row != midOfMatrix || mat.Length % 2 == 0)
                {
                    primarySummition += mat[row][row];
                    SecondrySummition += mat[row][numsOfColumns - (row + 1)];
                }
                
            }
            return primarySummition + SecondrySummition;
        }       
        
    }
}