public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int left = 0;
        int right = left + k - 1;

        int size = nums.Length - k + 1;
        int[] result = new int[size];
        int index = 0;

        while (right < nums.Length)
        {
            int maxInt = nums[left];

            for (int i = left + 1; i <= right; i++)
            {
                int currentInt = nums[i];

                if (currentInt > maxInt)
                    maxInt = currentInt;
            }

            result[index] = maxInt;
            index++;

            left++;
            right++;
        }

        return result;
    }
}