public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
       List<List<int>> done = new List<List<int>>();
       Array.Sort(nums);

       for (int i = 0; i < nums.Length; i++) {
            if (i != 0 && nums[i] == nums[i -1]) continue;

            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right) {
                if (nums[i] + nums[left] + nums[right] > 0) {
                    right--;
                    continue;
                }
                if (nums[i] + nums[left] + nums[right] < 0) {
                    left++;
                    continue;
                }
                if (nums[i] + nums[left] + nums[right] == 0) {
                    List<int> list = new List<int> { nums[i], nums[left], nums[right]};
                    done.Add(list);
                    left++;
                    right--;
                    while(left < right && nums[right] == nums[right + 1]) right--;
                    while(left < right && nums[left] == nums[left - 1]) left++;
                }
            }
       }

       return done;
    }
}
