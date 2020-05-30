using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveElementToEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            int toMove = 2;
            List<int> array = new List<int>();
            Initialize(array);
            var list = MoveElement(array, toMove);
        }

        static List<int> MoveElement(List<int> array, int toMove)
        {
            int left = 0;
            int right = array.Count - 1;

            while(left < right)
            {
                if (array[right] == toMove)
                {
                    right--;
                    continue;
                }

                if (array[left] == toMove)
                {
                    array[left] = array[right];
                    array[right] = toMove;
                }
                else
                    left++;
            }

            return array;
        }

        static void Initialize(List<int> array)
        {
            array.Add(2);
            array.Add(1);
            array.Add(2);
            array.Add(2);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(2);
        }
    }
}
