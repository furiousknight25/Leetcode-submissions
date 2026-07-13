public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

       for (int i = 0; i < numbers.Length; i++)  {
        for (int k = 0; k < numbers.Length; k++) {
            if (i != k && numbers[i] + numbers[k] == target) {
                return new int[] {i + 1,k + 1};// why are they shaped like this
            }
        }
       }

        return new int[] {};
    }
}
