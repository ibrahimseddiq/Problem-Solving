public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

        var dict = new Dictionary<string, List<string>>();
    
        foreach (string word in strs) {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);
        
            if (!dict.ContainsKey(key)) {
                dict[key] = new List<string>();
            }
            dict[key].Add(word);
        }
    
        return dict.Values.ToList();
    }
}   