using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static List<int> array;
        static void Main(string[] args)
        {
            Initialize();
            Sort();
        }

        public static void Sort()
        {
            for (int i = 1; i < array.Count; i ++)
            {
                int j = i;
                while(j > 0 && array[j] < array[j-1])
                {
                    Swap(array, j, j-1);
                    j -= 1;
                }
            }
        }

        private static void Swap(List<int> arr, int i, int j)
        {
            var arrTemp = arr[j];
            arr[j] = arr[i];
            arr[i] = arrTemp;
        }

        public static void Initialize()
        {
            array = new List<int>();
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
