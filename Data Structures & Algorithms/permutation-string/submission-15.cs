public class Solution {
    public bool CheckInclusion(string s1, string s2) {
       //add up ascii values in window? 
       int[] map1 = new int[36];
       int[] map2 = new int[36];
        int wl = s1.Length; //window length

        foreach (char i in s1) {
            map1[i - 'a']++; //oh single '' is a char while "" is a string, cool new tech
        }

       for (int second = wl; second < s2.Length + 1; second++)  
       {
        for (int i = second - wl; i < second; i++)
        {
            map2[s2[i] - 'a']++;
        }
        if (map1.SequenceEqual(map2)) return true;
        Array.Clear(map2, 0, map2.Length);
       }
       return false;
    }
}
