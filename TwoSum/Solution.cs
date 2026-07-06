public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> bag = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if(bag.ContainsKey(complement)) {
                return new int[] {bag[complement], i};
            }
            
            if(!bag.ContainsKey(nums[i]))
                bag.Add(nums[i], i);
        }
        return new int[0];
    }
}