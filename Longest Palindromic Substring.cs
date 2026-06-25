public class Solution
{
    public string LongestPalindrome(string s)
    {
        int currentLength = 0;
        int longestLength = 0;
        int left = 0;
        int right = 0;
        string longestPalindromee = "";
        for (int i = 0; i < s.Length; i++)
        {
            left = i - 1;
            right = i + 1;
            //test odd palindrome 
            while (left >= 0 && right < s.Length)
            {

                if (s[left].Equals(s[right]))
                {
                    left--;
                    right++;

                }
                else break;
            }
            left++;
            right--;
            if (right - left + 1 > longestPalindromee.Length)
            {
                longestPalindromee = s.Substring(left, right - left + 1);
            }

            //test even palindrome
            left = i;
            right = i + 1;
            while (left >= 0 && right < s.Length)
            {

                if (s[left].Equals(s[right]))
                {
                    left--;
                    right++;

                }
                else break;
            }
            left++;
            right--;
            if (right - left + 1 > longestPalindromee.Length)
            {
                longestPalindromee = s.Substring(left, right - left + 1);
            }



        }

        return longestPalindromee;



    }




}