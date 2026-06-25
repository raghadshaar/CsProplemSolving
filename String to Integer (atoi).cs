public class Solution
{
    public int MyAtoi(string s)
    {
        int i = 0;
        int n = s.Length;
        int sign = 1;
        int result = 0;

        // 1. skip spaces
        while (i < n && s[i] == ' ')
            i++;

        // 2. sign
        if (i < n && (s[i] == '+' || s[i] == '-'))
        {
            sign = (s[i] == '-') ? -1 : 1;
            i++;
        }

        // 3. build number
        while (i < n && s[i] >= '0' && s[i] <= '9')
        {
            int digit = s[i] - '0';

            // 4. overflow check
            if (result > int.MaxValue / 10 ||
               (result == int.MaxValue / 10 && digit > 7))
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + digit;
            i++;
        }

        return result * sign;
    }
}