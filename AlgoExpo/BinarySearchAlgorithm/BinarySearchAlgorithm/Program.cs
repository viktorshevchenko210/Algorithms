using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAlgorithm
{
    class Program
    {
        static List<int> array = new List<int>();
        static int target = 33;
        static void Main(string[] args)
        {
            Initialize();
            var index = BinarySearch();
        }

        public static int BinarySearch()
        {
            decimal left = 0;
            decimal right = array.Count - 1;
            return Search(array, left, right);       
        }

        public static int Search(List<int> array, decimal left, decimal right)
        {
            if (left > right)
                return -1;

            decimal divider = 2;
            int middle = (int)Math.Floor((left+right) / divider);

            if (array[middle] > target)
            {
                right = middle - 1;
                return Search(array, left, right);
            }
            else if (array[middle] < target)
            {
                left = middle + 1;
                return Search(array, left, right);
            }
            else if (array[middle] == target)
                return middle;

            return -1;
        }

        public static void Initialize()
        {
            array.Add(0);
            array.Add(1);
            array.Add(21);
            array.Add(34);
            array.Add(45);
            array.Add(45);
            array.Add(61);
            array.Add(71);
            array.Add(72);
            array.Add(73);
        }
    }
}
