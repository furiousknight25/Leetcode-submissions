public class Solution {
    public int CharacterReplacement(string s, int k) {
        // An array to store the frequency of each uppercase English letter in our current window
        int[] counts = new int[26]; 
        
        int left = 0;
        int maxLength = 0;
        int maxFrequencyInWindow = 0;

        // 'right' is equivalent to your 'second' pointer
        for (int right = 0; right < s.Length; right++) {
            // Add the current character to our frequency map
            counts[s[right] - 'A']++;
            
            // Keep track of the highest frequency of a single character in the current window
            maxFrequencyInWindow = Math.Max(maxFrequencyInWindow, counts[s[right] - 'A']);

            // The Current Window Size is: right - left + 1
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