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
    public bool HasCycle(ListNode head) {
                    if(head == null) 
            { 
                return false;
            }
            HashSet<ListNode> visited = new HashSet<ListNode>();
            visited.Add(head);
            while (head.next != null)
            {
                if(visited.Contains(head.next))
                {
                        return true; 
                }
                visited.Add(head.next);
                head = head.next;
            }
            return false;

    }
}
