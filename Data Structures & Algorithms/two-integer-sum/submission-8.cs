public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int letter1 = 0;
        int letter2 = 0;
        for (int i=0;i<nums.Length;i++) {
            letter1 = nums[i];
            for (int k=0;k<nums.Length;k++) {
                letter2 = nums[k];
                if (i!=k && letter1 + letter2 == target) {
                    return new int[] {i,k};
                }
            }
        }
        return new int[] {letter1,letter2};
    }
}
