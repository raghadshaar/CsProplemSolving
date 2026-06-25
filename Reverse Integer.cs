public class Solution
{
    public int Reverse(int x)
    {
        int reversed = 0;

        while (x != 0)
        {
            if (reversed > int.MaxValue / 10 || reversed < int.MinValue / 10)
            {
                reversed = 0;
                break;
            }

            reversed = (x % 10) + reversed * 10;
            x /= 10;
        }
        return reversed;
    }
}