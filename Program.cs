using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalQ1
{
    internal class Program
    {
        class MyStack
        {
            private List<int> list;

            public MyStack()
            {
                list = new List<int>();
            }

            public void Push(int n)
            {
                list.Add(n);
            }

            public int Pop()
            {
                int lastItem = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return lastItem;
            }

            public int Peek()
            {
                return list[list.Count - 1];
            }
        }

        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();
            myStack.Push(1);
            myStack.Push(2);

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());
        }
    }
}
