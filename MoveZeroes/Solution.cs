public class Solution {
    public void MoveZeroes(int[] arr) {
        int increaseIndex = 0;
        for(int i = 0; i < arr.Length; i++) {
            if(arr[i] != 0) {
                arr[increaseIndex] = arr[i];
                increaseIndex++;
            }
        }
        
        while(increaseIndex < arr.Length) {
            arr[increaseIndex] = 0;
            increaseIndex++;
        }
    }
}