using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LinkedList
{
    public class LinkedList
    {
		public Node Head;
		public Node Tail;

		public void SetHead(Node node)
		{
			node.Next = Head;
			Head.Prev = node;
			Head = node;
		}

		public void SetTail(Node node)
		{
			Tail.Next = node;
			node.Prev = Tail;
			Tail = node;
		}

		public void InsertBefore(Node node, Node nodeToInsert)
		{
			nodeToInsert.Next = node;
			nodeToInsert.Prev = node.Prev;

			node.Prev.Prev.Next = nodeToInsert;
			node.Prev = nodeToInsert;
		}

		public void InsertAfter(Node node, Node nodeToInsert)
		{
			nodeToInsert.Next = node.Next;
			nodeToInsert.Prev = node;
			node.Next = nodeToInsert;
		}

		public void InsertAtPosition(int position, Node nodeToInsert)
		{
			if(position == 1)
			{
				SetHead(nodeToInsert);
				return;
			}

			int counter = 0;
			var node = Head;
			while (counter != position)
			{
				counter++;
				if(counter == position)
				{
					var prev = node.Prev;

					prev.Next = nodeToInsert;
					node.Prev = nodeToInsert;

					nodeToInsert.Next = node;
					nodeToInsert.Prev = prev;
				}
				node = node.Next;
			}

		}

		public void RemoveNodesWithValue(int value)
		{
			var node = Head;

			while (node != null)
			{
				if(node.Value == value)
				{
					var prev = node.Prev;
					var next = node.Next;

					prev.Next = next;

					if (next != null)
						next.Prev = prev;
					else
						Tail = prev;
				}

				node = node.Next;
			}
		}

		public void Remove(Node node)
		{
			// Write your code here.
		}

		public bool ContainsNodeWithValue(int value)
		{
			// Write your code here.
			return false;
		}
	}
}
