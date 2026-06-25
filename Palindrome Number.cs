public class Solution
{
    public bool IsPalindrome(int x)
    {
        List<int> nums = new();
        if (x < 0)
        {
            return false;
        }
        while (x != 0)
        {
            nums.Add(x % 10);
            x = x / 10;
        }
        int right = nums.Count - 1;
        int left = 0;
        while (left < right)
        {
            if (nums[left] != nums[right])
            {
                return false;
            }
            left++;
            right--;

        }
        return true;
    }
}