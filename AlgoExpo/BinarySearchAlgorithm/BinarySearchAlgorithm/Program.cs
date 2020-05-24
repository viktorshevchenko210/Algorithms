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
            BinarySearch();
        }

        public static int BinarySearch()
        {
            decimal count = array.Count - 1;
            decimal divider = 2;

            var middle = Math.Floor(count / divider);
            

            return 0;
        }

        public static void Initialize()
        {
            array.Add(0);
            array.Add(1);
            array.Add(21);
            array.Add(33);
            array.Add(45);
            array.Add(45);
            array.Add(61);
            array.Add(71);
            array.Add(72);
            array.Add(73);
        }
    }
}
