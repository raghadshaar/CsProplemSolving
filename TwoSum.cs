public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int needed;
        int[] result = new int[2];
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {

            needed = target - nums[i];
            if (dict.ContainsKey(needed))
            {
                result[0] = dict[needed];
                result[1] = i;
                break;
            }
            else if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }

        }
        return result;

    }
}