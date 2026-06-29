public class Solution {
    public bool hasDuplicate(int[] nums) {
       for (int i = 0; i < nums.Length; i++) 
        {
            for (int k = 0; k < nums.Length; k++) {
                if (k != i && nums[i] == nums[k]) {
                    return true;
                }
            }
        }
        return false;
    }
}