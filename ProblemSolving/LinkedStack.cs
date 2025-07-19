using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class LinkedStack
    {
        public Node? Top;
        public void push (int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        public void pop ()
        {
            if (Top == null)
                throw new InvalidOperationException("Stack Underflow");
            Top = Top.Next;
        }

        public int peek ()
        {
            if (Top == null)
                throw new InvalidOperationException("Stack is empty");
            return Top.Data;
        }

        public void print()
        {
            Node node = Top;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
                
           }


    }
}
