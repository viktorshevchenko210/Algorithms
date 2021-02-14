using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinStack_155
{
    public class MinStack
    {
        List<int> list;
        int count;

        /** initialize your data structure here. */
        public MinStack()
        {
            count = 0;
            list = new List<int>();
        }

        public void Push(int x)
        {
            if (list.Count == count)
                list.Add(x);
            else
            {
                list[count] = x;
                //if(count == 0)
                //    list[count] = x;
                //else
                //{
                //    list[count - 1] = x;
                //}
            }
            count++;
        }

        public void Pop()
        {
            list[--count] = 0;
        }

        public int Top()
        {
            return list[count-1];
        }

        public int GetMin()
        {
            return list.GetRange(0, count).Min();
        }
    }
}
