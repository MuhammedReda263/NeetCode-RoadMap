using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class MinStack
    {
        List<int> stack = new List<int>();
        public MinStack()
        {

        }

        public void Push(int val)
        {
            stack.Add(val);
        }

        public void Pop()
        {
            stack.RemoveAt(stack.Count-1);
        }

        public int Top()
        {
            return stack.Last();
        }

        public int GetMin()
        {
            return stack.Min();
        }
    }
}
