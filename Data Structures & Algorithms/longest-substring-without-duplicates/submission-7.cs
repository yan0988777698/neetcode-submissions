public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int left = 0;
        int result = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (dict.ContainsKey(c) && dict[c] >= left)
            {
                // hint: 移動 left
                left = dict[c] + 1;
            }

            // hint: 更新 c 最新出現位置
            dict[c] = i;
            // hint: 更新目前最大長度
            result = Math.Max(i - left + 1, result);
        }

        return result;
    }
}