public class Solution
{
    public int LengthOfLongestSubstring(string s)

    {
        int length = 0;
        int left = 0;
        int longest = 0;
        HashSet<char> list = new HashSet<char>();
        for (int i = 0; i < s.Length; i++)
        {

            while (list.Contains(s[i]))
            {
                list.Remove(s[left]);
                left += 1;

            }
            list.Add(s[i]);
            length = i - left + 1;
            if (length > longest)
            {
                longest = length;
            }
        }

        return longest;

    }
}