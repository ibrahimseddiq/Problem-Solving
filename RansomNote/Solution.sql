public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var freq = new Dictionary<char, int>();
        foreach(char c in magazine) {
            if(freq.ContainsKey(c)) freq[c]++;
            else freq[c] = 1;
        }
        foreach(char c in ransomNote) {
            if(!freq.ContainsKey(c) || freq[c] == 0) return false;
            freq[c]--;
        }
        return true;
    }
}