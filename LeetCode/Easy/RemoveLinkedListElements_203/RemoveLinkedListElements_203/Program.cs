using System;

namespace RemoveLinkedListElements_203
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(6);
            //head.next.next.next = new ListNode(3);
            //head.next.next.next.next = new ListNode(4);
            //head.next.next.next.next.next = new ListNode(5);
            //head.next.next.next.next.next.next = new ListNode(6);

            int val = 1;

            RemoveElements(head, val);
        }

        static ListNode RemoveElements(ListNode head, int val)
        {

            ListNode previous = null;
            var headNext = head;

            while (headNext != null)
            {
                if (headNext.val == val)
                {
                    if (previous == null)
                    {
                        headNext = headNext.next;
                        head = head.next;
                        continue;
                    }
                    else
                    {
                        previous.next = headNext.next;
                        headNext = previous;
                        continue;
                    }
                }

                previous = headNext;
                headNext = headNext.next;
            }

            return head;
        }
    }
}
