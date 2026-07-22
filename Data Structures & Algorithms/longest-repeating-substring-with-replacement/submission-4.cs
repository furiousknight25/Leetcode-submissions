public class Solution {
    public int CharacterReplacement(string s, int k) {
        // An array to store the frequency of each uppercase English letter in our current window
        int[] counts = new int[26]; //asci subtraction, ex a = 65, c = 67 67 - 65 = 2 this is the "bucket" index
        int left = 0;
        int maxLength = 0;
        int maxFrequencyInWindow = 0;

        // 'right' is equivalent to your 'second' pointer
        for (int right = 0; right < s.Length; right++) {
            // Add the current character to our frequency map
            counts[s[right] - 'A']++; //what is this syntax?
            
            // Keep track of the highest frequency of a single character in the current window
            maxFrequencyInWindow = Math.Max(maxFrequencyInWindow, counts[s[right] - 'A']); // 
            //if its not our target, index goes up while max freq does not stay big enough to cancel
            // the negative, creating a higher k comparison value 

            // The Current Window Size is: right - left + 1 why plus 1? and minux maxfrequency in window
            // the negative(inverse) is anything other than our max freq(target) a subtraction gives us the negative frequency
            // If the number of characters we need to replace exceeds our budget (k)
            while ((right - left + 1) - maxFrequencyInWindow > k) {
                // We must shrink the window from the left.
                // First, remove the leftmost character's count from our map
                counts[s[left] - 'A']--;
                // Then move the left pointer forward
                left++;
            }

            // After ensuring the window is valid, update our maximum length found so far
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}