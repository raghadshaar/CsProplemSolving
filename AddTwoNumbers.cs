/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode();
        ListNode Head = result;

        int sum = 0;
        int carry = 0;
        int digit;
        while (l1 != null || l2 != null)
        {
            sum = (l1 is null ? 0 : l1.val) + (l2 is null ? 0 : l2.val) + carry;


            carry = sum / 10;
            digit = sum % 10;

            if (l1 is not null) l1 = l1.next;
            if (l2 is not null) l2 = l2.next;

            result.next = new ListNode(digit);
            sum = 0;
            result = result.next;

        }
        if (carry != 0)
        {
            result.next = new ListNode(carry);
        }
        return Head.next;
    }
}