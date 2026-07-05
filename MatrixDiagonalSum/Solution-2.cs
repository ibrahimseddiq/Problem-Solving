public class Solution {
    public int DiagonalSum(int[][] mat) 
    {
        int sum = 0;
        int n = mat.Length;

        for (int i = 0; i < n; i++)
        {
            // 1. جمع عنصر القطر الرئيسي
            sum += mat[i][i];
            
            // 2. جمع عنصر القطر الثانوي
            sum += mat[i][n - 1 - i];
        }

        // 3. لو المصفوفة حجمها فردي، بنطرح العنصر اللي في النص لأنه اتجمع مرتين
        if (n % 2 != 0)
        {
            sum -= mat[n / 2][n / 2];
        }

        return sum;
    }
}