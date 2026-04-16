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
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
                    ListNode curr1 = list1;
            ListNode curr2 = list2;
            ListNode head = list1;

            if(curr1 == null && curr2 == null)
                return head;
            if (curr1 == null && curr2 != null)
            {
                return list2;
            }
            else if(curr2 == null && curr1 != null)
            {
                return list1;
            }

                        if (curr1.val <= curr2.val)
            {
                head = curr1;
                if (curr1.next != null)
                {
                    curr1 = curr1.next;
                }
                else
                    curr1 = null;
            }
            else
            {
                head = list2;
                if (curr2.next != null)
                    curr2 = curr2.next;
                else
                {
                    curr2 = null;
                }
            }
            ListNode temp = head;
            while (curr1 != null || curr2 != null)
            {
                if (curr2 == null || curr1 != null && curr1.val <= curr2.val)
                {
                    temp.next = curr1;
                    if (curr1.next != null)
                    {
                        curr1 = curr1.next;
                        temp = temp.next;
                    }
                    else
                    {
                        temp = temp.next;
                        curr1 = null;
                    }
                }
                else if (curr1 == null || curr2 != null && curr2.val <= curr1.val )
                {
                    {
                        temp.next = curr2;
                        if (curr2.next != null)
                        {
                            curr2 = curr2.next;
                            temp = temp.next;
                        }
                        else
                        {
                            temp = temp.next;
                            curr2 = null;
                        }
                    }
                }
            }
            return head;
    }
}