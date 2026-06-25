public class Solution
{
    public int MaxArea(int[] height)
    {
        int max = 0;
        int left = 0;
        int area = 0;
        int right = height.Length - 1;
        while (left < right)
        {
            area = (right - left) * Math.Min(height[left], height[right]);
            if (area > max) { max = area; }
            if (height[left] < height[right])
                left++;
            else
                right--;
        }
        return max;


    }
}