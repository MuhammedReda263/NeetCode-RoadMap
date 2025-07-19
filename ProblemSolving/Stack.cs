using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class CustomStack<T>
    {
        private readonly T[] StackArray;
        private  int top;

        public CustomStack(int size)
        {
            StackArray = new T [size];
            top = -1;
        }

        public void Push(T item)
        {
            if (top == StackArray.Length-1)
            {
                throw new Exception("Stack is full complete");
            }

            ++top;
            StackArray[top] = item;
        }
        public T Pop()
        {
            if (top < 0)
            {
                throw new Exception("Stack is empty");
            }
            --top;
            return StackArray[top+1];
        }

        public T Peek ()
        {
            return StackArray [top];
        }

        public bool isEmpty () => StackArray.Length == 0;
        public bool isFull () => top == StackArray.Length-1;

        public void Print ()
        {
            int i = 0;
           while (i <= top)
            {
                Console.WriteLine(StackArray[i]);
                i++;
            }
        }
    }
}
