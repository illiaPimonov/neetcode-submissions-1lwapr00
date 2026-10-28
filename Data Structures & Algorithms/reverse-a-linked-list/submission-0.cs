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

        Stack<int> res = new Stack<int>();

        while (head != null) {
            res.Push(head.val);
            head = head.next;
        }

        ListNode newHead = new ListNode(res.Pop());
        ListNode current = newHead;

        while (res.Count > 0) {
            current.next = new ListNode(res.Pop());
            current = current.next;
        }

        return newHead;
}
}
