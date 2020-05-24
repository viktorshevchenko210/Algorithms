using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static LinkedList linkedList;
        static void Main(string[] args)
        {
            Initialize();

            var newHead = new Node(4);
            var newTail = new Node(6);
            var before = new Node(3);
            var after = new Node(3);
            var insertAtPosition = new Node(10);

            //linkedList.SetHead(newHead);
            //linkedList.SetTail(newTail);
            //linkedList.InsertBefore(linkedList.Tail, before);
            //linkedList.InsertAfter(linkedList.Tail, after);
            //linkedList.InsertAtPosition(1, insertAtPosition);
            //linkedList.RemoveNodesWithValue(3);


        }

        static void Initialize()
        {
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Prev = head;

            head.Next.Next = new Node(3);
            head.Next.Next.Prev = head.Next;

            head.Next.Next.Next = new Node(4);
            head.Next.Next.Next.Prev = head.Next.Next;

            head.Next.Next.Next.Next = new Node(5);
            head.Next.Next.Next.Next.Prev = head.Next.Next.Next;


            linkedList = new LinkedList();
            linkedList.Head = head;
            linkedList.Tail = head.Next.Next.Next.Next;

        }
    }
}
