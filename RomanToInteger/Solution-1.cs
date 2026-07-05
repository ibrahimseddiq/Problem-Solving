
public class Solution {
    public int RomanToInt(string s) {
        var sympol = new Dictionary<char, int>();
        sympol['I'] = 1;
        sympol['V'] = 5;
        sympol['X'] = 10;
        sympol['L'] = 50;
        sympol['C'] = 100;
        sympol['D'] = 500;
        sympol['M'] = 1000;

        int sum = 0;

        for(int i = 0; i < s.Length - 1; i++) {
            if(sympol[s[i]] >= sympol[s[i+1]]) {
                if(i+1 == s.Length - 1) {
                    sum += sympol[s[i]] + sympol[s[i+1]];;
                }
                else
                    sum += sympol[s[i]];
            }

            else {
                sum += sympol[s[i+1]] - sympol[s[i]];
                i++;
            }
        }
        return sum;
    }
}