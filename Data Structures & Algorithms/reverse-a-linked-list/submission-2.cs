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
        if (head == null)
            return null;

        Stack<ListNode> res = new Stack<ListNode>();

        while (head != null) {
            res.Push(head);
            head = head.next;
        }

        ListNode newHead = res.Pop();
        ListNode current = newHead;

        while (res.Count > 0) {
            current.next = res.Pop();
            current = current.next;
        }

        current.next = null;

        return newHead;
    }
}
