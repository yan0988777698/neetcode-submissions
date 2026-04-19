public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;

        int left = 0;
        int right = s1.Length - 1;

        int[] s1Count = new int[26];
        int[] windowCount = new int[26];

        foreach (char c in s1)
        {
            s1Count[c - 'a']++;
        }

        for (int i = 0; i <= right; i++)
        {
            windowCount[s2[i] - 'a']++;
        }

        while (right < s2.Length)
        {
            if (IsSame(s1Count, windowCount))
                return true;

            if (right == s2.Length - 1)
                break;

            windowCount[s2[left] - 'a']--;
            left++;
            right++;
            windowCount[s2[right] - 'a']++;
        }

        return false;
    }

    private bool IsSame(int[] a, int[] b)
    {
        for (int i = 0; i < 26; i++)
        {
            if (a[i] != b[i])
                return false;
        }

        return true;
    }
}