using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    /// <summary>
    /// Find the smallest number
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            List<int> array = new List<int>();
            Initialize(array);
            Sort(array);
        }

        static void Sort(List<int> array)
        {

            for (int i = 0; i < array.Count; i++)
            {
                int smallestNumber = array[i];
                int smallestNumberIndex = i;

                for(int j = i + 1; j < array.Count; j++)
                {
                    if (smallestNumber > array[j])
                    {
                        smallestNumber = array[j];
                        smallestNumberIndex = j;
                    }
                }

                Swap(array, i, smallestNumberIndex);
            }
        }

        static void Swap(List<int> array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;

        }

        public static void Initialize(List<int> array)
        {
            array.Add(8);
            array.Add(5);
            array.Add(2);
            array.Add(9);
            array.Add(5);
            array.Add(6);
            array.Add(3);
        }
    }
}
