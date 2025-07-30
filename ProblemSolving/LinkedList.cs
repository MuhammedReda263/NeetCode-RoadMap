using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
	public class Nodee
	{
		public int value;
		public Nodee? next;
		public Nodee(int val)
		{
			value = val;
			next = null;
		}
	}

	public class MyLinkedList
	{
		private Nodee head;
		public MyLinkedList()
		{
			head = null;
		}

		public void addFirst(int val)
		{
			if (head == null)
			{
				Nodee nodee = new Nodee(val);
				head = nodee;
				return;

			}
			Nodee node = new Nodee(val);
			node.next = head;
			head = node;
			return;
		}

		public void AddLast(int val)
		{
			if (head == null)
			{
				Nodee nodee = new Nodee(val);
				head = nodee;
				return;
			}
			Nodee node = new Nodee(val);
			Nodee current = head;
			while (current.next != null)
			{
				current = current.next;
			}
			current.next = node;

		}

		public void InsertAfter(int target, int val)
		{
			Nodee cuurent = head;
			while (cuurent != null && cuurent.value != target) {
				cuurent = cuurent.next;
			}
			if (cuurent != null)
			{
				Nodee newNode = new Nodee (val);
				newNode.next = cuurent.next;
				cuurent.next = newNode;

			}
			else
			{
				Console.WriteLine($"Node with value {target} not found.");

			}

		}

		public void DeleteFirst()
		{
			if (head != null)
			{
				head = head.next;
			}
		}

		public void DeleteByValue(int val)
		{
			if (head == null) return;

			if (head.value == val)
			{
				head = head.next;
				return;
			}

			Nodee current = head;
			
				while ( current != null && current.next.value != val)
				{
					current = current.next;
				}

				if ( current.next.value == val)
			{
				current.next = current.next.next;
				return;
			}
			Console.WriteLine($"Node with value {val} not found.");


		}

		public bool Search(int val)
		{
                if (head == null) return false;
			Nodee current = head;
				while (current.value != val && current.next != null)
			{
				current = current.next;
			}
				if( current.value == val)
				return true;
				else return false;
		}

		public void PrintList()
		{
			Nodee current = head;
			while (current != null)
			{
				Console.Write(current.value + " -> ");
				current = current.next;
			}
			Console.WriteLine("null");
		}

		public Nodee ReverseList(Nodee head)
		{
			Nodee prev = null;
			Nodee current = head;

			while (current != null)
			{
				Nodee next = current.next;
				current.next = prev;
				prev = current;
				current = next;
			}

			return prev;
		}

		public Nodee MergeTwoLists(Nodee list1, Nodee list2)
		{
			if (list1 == null || list2 == null)
				return null;
			Nodee current;
			if (list1.value < list2.value)
			{
				current=list1;
				list1 = list1.next;
			}
			else
			{
				current = list2;
				list2 = list2.next;
			}
			Nodee prev = current;

			while (list1 !=null || list2 != null)
			{
				if (list1.value < list2.value)
				{
					prev.next = list1;
					list1 = list1.next;
				}
				else if (list1.value> list2.value)
				{
					prev.next = list2;
					list2 = list2.next;

				}
			}
			if (list1 == null && list2 != null)
			{
				while (list2 != null)
				{
					prev.next = list2;
					list2 = list2.next;
				}
			}
			else if (list1 != null && list2 == null)
			{
				while (list1 != null)
				{
					prev.next = list1;
					list1 = list1.next;
				}
			}
			return current;
		}
	}
}