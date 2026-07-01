public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {return false;}

        foreach (char i in s) {
            int freq1 = FreqCounter(s,i);
            int freq2 = FreqCounter(t,i);
            if (freq1 != freq2) {return false;}
        }
        return true;
    }

    public int FreqCounter(string w, char c) {
        int count = 0;
        foreach (char i in w) {
            if (i == c) {
                count++;
            }
        }
        return count;
    }
}
