using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
        }

        static ListNode ReverseList(ListNode head)
        {
            ListNode newHead = null;

            while (head != null)
            {
                if (newHead == null)
                    newHead = new ListNode(head.val);
                else
                {
                    var node = new ListNode(head.val);
                    node.next = newHead;
                    newHead = node;
                }

                head = head.next;
            }

            return newHead;
        }
    }
}
