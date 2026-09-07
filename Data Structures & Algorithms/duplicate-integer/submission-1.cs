public class Solution {
    public bool hasDuplicate(int[] nums) {
        /*Brute Force*/
        /*
        int count = 0;
        for(int i=0;i<nums.Length;i++){
            for(int j=0;j<nums.Length;j++){
                if(nums[i] == nums[j] && i != j){
                    return true;
                }
            }
        }
        return false;
        */

        /*Optimal Approach - Hash Set*/
        HashSet<int> seen = new HashSet<int>();
        foreach(var num in nums){
            if(seen.Contains(num))  return true;
            seen.Add(num);
        }
        return false;
    }
}