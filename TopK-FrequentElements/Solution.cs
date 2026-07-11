public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>(); // num[i], count(num[i])
        foreach(int num in nums) {
            if(freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }
        var sortedValues = freq.OrderByDescending(x => x.Value);
        var topK = sortedValues.Take(k);
        int[] result = new int[k];
        int i = 0;
        foreach(var pair in topK) {
            result[i] = pair.Key;
            i++;
        }
        return result;
    }
}