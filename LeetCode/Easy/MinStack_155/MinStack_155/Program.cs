using System;

namespace MinStack_155
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();

            minStack.Push(2147483646);
            minStack.Push(2147483646);
            minStack.Push(2147483647);

            var top1 = minStack.Top();
            minStack.Pop();

            var min1 = minStack.GetMin();
            minStack.Pop();

            var min2 = minStack.GetMin();
            minStack.Pop();

            minStack.Push(2147483647);

            var top2 = minStack.Top();

            var min3 = minStack.GetMin();

            minStack.Push(-2147483648);

            var top3 = minStack.Top();

            var min4 = minStack.GetMin();

            minStack.Pop();

            var min5 = minStack.GetMin();
        }
    }
}
