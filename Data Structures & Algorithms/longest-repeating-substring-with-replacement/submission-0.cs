public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int left = 0;
        int result = 0;
        int maxCount = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i]))
                dict[s[i]] = 0;

            dict[s[i]]++;

            // hint 1: 更新目前視窗內最高頻次
            maxCount = Math.Max(maxCount, dict[s[i]]);

            // hint 2: 如果目前視窗不合法，就縮左邊
            while ((i - left + 1) - maxCount > k)
            {
                dict[s[left]]--;
                left++;
            }

            // hint 3: 更新答案
            result = Math.Max(result, i - left + 1);
        }

        return result;
    }
}