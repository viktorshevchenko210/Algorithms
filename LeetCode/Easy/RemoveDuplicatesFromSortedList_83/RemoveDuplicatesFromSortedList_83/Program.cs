using System;

namespace RemoveDuplicatesFromSortedList_83
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(1);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(3);


            var listNode = DeleteDuplicates(head);

        }

        static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return head;

            var current = head;
            while(current != null && current.next != null)
            {
                if(current.next.val == current.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return head;
        }
    }
}
