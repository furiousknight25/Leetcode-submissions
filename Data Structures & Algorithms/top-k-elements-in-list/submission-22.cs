public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int,int>();

        foreach (int i in nums) {
            if (!map.ContainsKey(i)) {
               map[i] = 1;
            }
            else {
                map[i]++;
            }
        }
        int[] output = new int[k];

        List<int>[] bucket = new List<int>[nums.Length + 1];
        foreach (var (key, value) in map) {
            if (bucket[value] == null) {
                bucket[value] = new List<int>();
            }
            bucket[value].Add(key);
        }
        
        var count = 0;
        for (int i = bucket.Length; i > 0; i--) {
            if (bucket[i] != null) {
                foreach (int num in bucket[i]) {
                    output[count] = num;
                    count++;
                    
                    if (count == k) return output; // Return as soon as we hit k
                }
            }
        }


        // foreach (var (key, value) in map) {// loop thorugh eahc key and value
        //     Console.WriteLine(value);
        //     for (int i = 0; i < output.Length; i++) {
        //         int idx = 0;
        //         while (value >= output[i] &&) { 
        //             output[i] = key;
        //             break;
        //         }
        //     }
        // }

        return output;
    }
}
