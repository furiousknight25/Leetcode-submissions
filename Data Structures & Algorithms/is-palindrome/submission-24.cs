public class Solution {
    public bool IsPalindrome(string s) {
        int endidx = s.Length - 1;
        int i = 0;
        while (i < endidx) {
            if (!(Char.IsLetter(s[i]) || Char.IsNumber(s[i]))) {
                i++;
                continue;
            }
            else if (!(Char.IsLetter(s[endidx]) || Char.IsNumber(s[endidx]))) {
                endidx--;
                continue;
            }
            
            if (Char.ToLower(s[i]) != Char.ToLower(s[endidx])) {
                return false;
            }
            i++;
            endidx--;

        }
        return true;
    } 
}
