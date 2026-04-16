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
    public ListNode ReverseList(ListNode head) {
             if(head == null)
            {
                return null;
            }
            ListNode currentNode = head;
            ListNode head2;
            Stack<ListNode> result = new Stack<ListNode>();
            while (currentNode.next != null)
            {
                result.Push(currentNode);
                currentNode = currentNode.next;
            }
            head2 = currentNode;
            while(result.Count != 0)
            {
                currentNode.next = result.Pop();
                currentNode = currentNode.next;
            }
            currentNode.next = null;
            return head2;
    }
}
