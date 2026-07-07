using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {

        string finalString = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();
        
        int i = 0;
        int j = finalString.Length - 1;
        while (i < j) {
            if (finalString[i] != finalString[j])
                return false;
            i++; j--;
        }
        return true;
    }
}