public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

    IList<IList<string>> result = new List<IList<string>>();

    if (strs.Length == 0) return result;
    
    result.Add(new List<string>{strs[0]});
    
    for(int element = 1; element < strs.Length; element++) {
        bool added = false;
        
        for(int row = 0; row < result.Count; row++) {
            if(IsAnagram(strs[element], result[row][0])) {
                result[row].Add(strs[element]);
                added = true;
                break;
            }
        }
        
        if(!added) {
            result.Add(new List<string>{strs[element]});
        }
    }
    
    return result;
}

    public bool IsAnagram(string a, string b) {
        if(a.Length != b.Length) return false;

        int[] charCount = new int[26];

        for(int i = 0; i < a.Length; i++) {
            charCount[a[i] - 'a']++;
            charCount[b[i] - 'a']--;
        }

        foreach(int c in charCount) {
            if(c != 0) return false;
        }
        return true;
    }
}