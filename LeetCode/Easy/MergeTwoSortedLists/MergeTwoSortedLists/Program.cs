using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new ListNode(1);
            first.next = new ListNode(2);
            first.next.next = new ListNode(4);

            var second = new ListNode(1);
            second.next = new ListNode(3);
            second.next.next = new ListNode(4);

            var result = MergeTwoLists(first, second);
        }

        static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            else if (l2 == null)
                return l1;

            ListNode d = new ListNode(),
                     cur = d;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }

                cur = cur.next;
            }

            if (l1 != null)
                cur.next = l1;

            if (l2 != null)
                cur.next = l2;

            return d.next;
        }
    }
}
