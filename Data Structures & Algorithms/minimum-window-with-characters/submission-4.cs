public class Solution
{
    public string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || t.Length > s.Length)
            return string.Empty;

        Dictionary<char, int> need = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();

        foreach (char c in t)
        {
            if (!need.ContainsKey(c))
                need[c] = 0;

            need[c]++;
        }

        int required = need.Count;
        int formed = 0;
        int left = 0;

        int minLength = int.MaxValue;
        int startIndex = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char rightChar = s[right];

            if (need.ContainsKey(rightChar))
            {
                if (!window.ContainsKey(rightChar))
                    window[rightChar] = 0;

                window[rightChar]++;

                if (window[rightChar] == need[rightChar])
                    formed++;
            }

            while (formed == required)
            {
                int currentLength = right - left + 1;

                if (currentLength < minLength)
                {
                    minLength = currentLength;
                    startIndex = left;
                }

                char leftChar = s[left];

                if (need.ContainsKey(leftChar))
                {
                    window[leftChar]--;

                    if (window[leftChar] < need[leftChar])
                        formed--;
                }

                left++;
            }
        }

        return minLength == int.MaxValue
            ? string.Empty
            : s.Substring(startIndex, minLength);
    }
}