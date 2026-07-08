public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> orgs = new Dictionary<string, List<string>>();

        foreach (string s in strs) {

            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string key = new String(chars);

            if (!orgs.ContainsKey(key)) {
                orgs[key] = [s];
            }
            else {
                orgs[key].Add(s);
            }

        }
        return new List<List<string>>(orgs.Values);
    }
    
    public bool CheckAnagrams(string word, string checker) 
    {
        if (word.Length != checker.Length) return false;

        Dictionary<char, int> freq = new Dictionary<char,int>();

        foreach (char a in word) {
            if (!freq.ContainsKey(a)) { freq[a] = 1 ;}
            else { freq[a]++;}
        }

        foreach (char b in checker)
        {
            if (freq.ContainsKey(b)) {
                freq[b]--;
            }
            else {return false;}
        }
        foreach (int c in freq.Values)
        {
            if (c < 0) return false;
        }
        return true;
    }
}