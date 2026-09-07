public class Solution {
    public int[] GetConcatenation(int[] nums) {
        /*Brute Force*/
        /*
        int n = nums.Length;
        List<int> result = new List<int>();
        for(int i=0;i<n;i++){
            result.Add(nums[i]); 
        }
        for(int i=0;i<n;i++){
            result.Add(nums[i]);
        }
        return result.ToArray();  
        */

        int n = nums.Length;
        int[] result = new int[2*n];
        for(int i=0;i<n;i++){
            result[i] = nums[i];
            result[i+n] = nums[i]; 
        }
        return result;
    }
}