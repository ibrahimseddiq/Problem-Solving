public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) return false;

        int[] charCount = new int[26];

        for(int i = 0; i < s.Length; i++) {
            charCount[s[i] - 'a']++;
            charCount[t[i] - 'a']--;
        }

        foreach(int c in charCount) {
            if(c != 0) return false;
        }
        return true;
    }
}