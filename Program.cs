using System;
class Program
{

    (String FirstName, String LastName) fullName = ("Raghad", "Shaar");
    public static bool And(bool a, bool b) =>
        (a, b) switch
        {
            (true, true) => true,
            _ => false

        };
    public static bool Or(bool a, bool b) =>
            (a, b) switch
            {
                (false, false) => false,
                _ => true
            };



    public static int[] TwoSum(int[] nums, int target)
    {
        int needed;
        int[] result = new int[2];
        Dictionary<int, int> dict= new Dictionary<int, int>();
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
    static void Main()
    {
        Console.WriteLine("Two Sum Proplem :");
        int[] ints = [2, 11,6,9, 15,6,7,4];
        int[] results = TwoSum(ints, 10);
        Console.WriteLine("Indecies are {0},{1}", results[0], results[1]);

    }
}