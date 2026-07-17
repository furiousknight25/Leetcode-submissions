public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s == "") return 0;
        int first = 0;
        int second = 0;
        int max_length = 1;
        HashSet<int> set = new HashSet<int>();

        while (second <= s.Length - 1 && first < s.Length){
            if (set.Contains(s[second])) {
               max_length = Math.Max(max_length, set.Count);
                set.Remove(s[first]);
                first++;
            }
            else {
               set.Add(s[second]);
               max_length = Math.Max(max_length, set.Count);
               second++;
            }
        }
        return max_length;
    }
}
