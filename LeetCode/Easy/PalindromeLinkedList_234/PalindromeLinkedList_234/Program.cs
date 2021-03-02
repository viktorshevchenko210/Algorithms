using System;
using System.Collections.Generic;

namespace PalindromeLinkedList_234
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(2);
            head.next.next.next.next = new ListNode(1);
            IsPalindrome(head);
        }

        static bool IsPalindrome(ListNode head)
        {
            bool isOdd = false;

            int size = GetLength(head);
            if (size == 1)
                return true;

            if (size % 2 != 0)
                isOdd = true;

            int half = size / 2;

            var current = head;
            int step = 0;

            ListNode reversedLeftHalf = null;

            while (current != null)
            {
                if (isOdd)
                {
                 
                    if(step > half)
                    {
                        if (current.val != reversedLeftHalf.val)
                            return false;

                        reversedLeftHalf = reversedLeftHalf.next;
                    }
                }
                else
                {
                    if(step >= half)
                    {
                        if (current.val != reversedLeftHalf.val)
                            return false;

                        reversedLeftHalf = reversedLeftHalf.next;
                    }
                }

                if (step < half)
                {
                    if (reversedLeftHalf == null)
                        reversedLeftHalf = new ListNode(current.val);
                    else
                    {
                        var node = new ListNode(current.val);
                        node.next = reversedLeftHalf;
                        reversedLeftHalf = node;
                    }
                }

                step++;
                current = current.next;
            }

            return true;
        }


        static int GetLength(ListNode head)
        {
            int size = 0;

            var current = head;
            while(head != null)
            {
                size++;
                head = head.next;
            }

            return size;
        }
    }
}
