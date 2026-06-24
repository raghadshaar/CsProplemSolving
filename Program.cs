using System;
using System.ComponentModel.Design;

class Program
{

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode();
        ListNode Head = result;

        int sum = 0;
        int carry = 0;
        int digit;
        while (l1 != null || l2 != null)
        {
            sum =( l1 is null? 0: l1.val )+ (l2 is null ? 0:l2.val)+ carry ;

         
                carry = sum /10; 
                digit = sum % 10;

            if(l1 is not null) l1 = l1.next;
            if(l2 is not null) l2 = l2.next;

            result.next = new ListNode(digit);
            sum = 0;
            result = result.next;
         
        }
        if(carry != 0)
        {
            result.next = new ListNode(carry);
      }
            return Head.next;
    }
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

    //Third Problem

    public static int LengthOfLongestSubstring(string s)

    {   int length = 0;
        int left = 0;
        int longest = 0;
        HashSet <char> list = new HashSet<char>();
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



    //4th problem


    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        double median = 0;
        int p1 = 0;
        int p2 = 0;
        int endflag1 = 0;
        int endflag2 = 0;



        int[] merged = new int[nums1.Length + nums2.Length];
         if(nums1.Length ==0)
        {
            if(nums2.Length == 0)
            {
                return 0;
            }
            else
            {
                endflag1 = 1;
            }

        }
        if (nums2.Length == 0)
        {
            endflag2 = 1;
        }

            for (int i = 0; i < (nums2.Length + nums1.Length); i++)


        { 
            if (endflag1 == 0)
            {
                if (endflag2 == 0)
                {
                    if (nums1[p1] < nums2[p2])
                    {
                        merged[i] = nums1[p1];
                        p1++;
                        if (p1 == nums1.Length)
                        {
                            endflag1 = 1;
                        }
                    }
                    else
                    {

                        merged[i] = nums2[p2];
                        p2++;
                        if (p2 == nums2.Length)
                        {
                            endflag2 = 1;
                        }
                    }
                }
                else
                {
                    merged[i] = nums1[p1];
                    p1++;
                    if (p1 == nums1.Length)
                    {
                        endflag1 = 1;
                    }
                }
            }
            else if (endflag2 == 0)
            {

                merged[i] = nums2[p2];
                p2++;
                if (p2 == nums2.Length)
                {
                    endflag2 = 1;

                }
            }
        }

        median = merged.Length % 2 == 1
            ? merged[merged.Length / 2]
            : (merged[merged.Length / 2 - 1] + merged[merged.Length / 2]) / 2.0;

        return median;



    }
    static void Main()
    {
        Console.WriteLine("------------------------------------------------------------------------------------------");

        // First Problem : Two Sum 
        Console.WriteLine("Two Sum Problem :");
        int[] ints = [2, 11,6,9, 15,6,7,4];
        int[] results = TwoSum(ints, 10);
        Console.WriteLine("Indecies are {0},{1}", results[0], results[1]);



        //Seconed Problem : Add Two Numbers 

        ListNode l1 = new ListNode(2,
                  new ListNode(4,
                  new ListNode(3)));

        ListNode l2 = new ListNode(5,
                        new ListNode(6,
                        new ListNode(4)));

        ListNode result = AddTwoNumbers(l1, l2);
        Console.WriteLine("------------------------------------------------------------------------------------------");

        Console.WriteLine("Add two numbers  :");

        while (result != null)
        {
            Console.WriteLine(result.val + " ");
            result = result.next;
        }

        Console.WriteLine("------------------------------------------------------------------------------------------");


        //Third Problem :
        Console.WriteLine("length of longest string in \"rarttyghRaghad\" is {0}", LengthOfLongestSubstring("rarttyghRaghad"));



        Console.WriteLine("------------------------------------------------------------------------------------------");


        int[] nums1 = [1, 2, 3, 4];
        int[] nums2 = [7, 8, 9, 10];
        //4th problem :
        Console.WriteLine("Median of two sorted Arrays :"+FindMedianSortedArrays(nums1, nums2));




        
    }













}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}