using System;

namespace IntersectionOfTwoLinkedLists_160
{
    class Program
    {
        static void Main(string[] args)
        {
            //intersectVal = 8, listA = [4, 1, 8, 4, 5], listB = [5, 6, 1, 8, 4, 5], skipA = 2, skipB = 3

            ListNode headA = new ListNode(4);
            headA.next = new ListNode(1);
            headA.next.next = new ListNode(8);
            headA.next.next.next = new ListNode(4);
            headA.next.next.next.next = new ListNode(5);


            ListNode headB = new ListNode(5);
            headB.next = new ListNode(6);
            headB.next.next = new ListNode(1);
            headB.next.next.next = new ListNode(8);
            headB.next.next.next = new ListNode(4);
            headB.next.next.next = new ListNode(5);

            var intersection = GetIntersectionNode(headA, headB);
        }

        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;


        }
    }
}
