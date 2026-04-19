public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>(); for (int i = 0; i < nums.Length; i++) { int current = nums[i]; if (!dict.ContainsKey(current)) { dict.Add(current, 0); continue; } else { return true; } } return false;
    }
}