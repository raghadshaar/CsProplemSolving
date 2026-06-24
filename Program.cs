using System;
using System.ComponentModel.Design;

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
    //

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
    static void Main()
    {

       // First Proplem : Two Sum 
        Console.WriteLine("Two Sum Proplem :");
        int[] ints = [2, 11,6,9, 15,6,7,4];
        int[] results = TwoSum(ints, 10);
        Console.WriteLine("Indecies are {0},{1}", results[0], results[1]);



        //Seconed Proplem : Add Two Numbers 

        ListNode l1 = new ListNode(2,
                  new ListNode(4,
                  new ListNode(3)));

        ListNode l2 = new ListNode(5,
                        new ListNode(6,
                        new ListNode(4)));

        ListNode result = AddTwoNumbers(l1, l2);

        Console.WriteLine("Add two numbers  :");

        while (result != null)
        {
            Console.Write(result.val + " ");
            result = result.next;
        }

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