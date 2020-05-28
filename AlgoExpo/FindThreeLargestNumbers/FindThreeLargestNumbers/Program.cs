using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThreeLargestNumbers
{
    class Program
    {
        static List<int> array;


        static void Main(string[] args)
        {
            Initialize();
            int[] arrayNew = new int[3];
            FindThreeLargestNumbers(arrayNew);
        }

        static public void FindThreeLargestNumbers(int[] arrayNew)
        {
            foreach(var list in array)
            {
                if (list > arrayNew[2])
                {
                    var second = arrayNew[1];
                    var third = arrayNew[2];
                    arrayNew[2] = list;
                    arrayNew[1] = third;
                    arrayNew[0] = second;
                }
                else if(list > arrayNew[1])
                {
                    var second = arrayNew[1];
                    arrayNew[1] = list;
                    arrayNew[0] = second;
                }
                else if(list > arrayNew[0])
                {
                    arrayNew[0] = list;
                }
            }
        }

        public static void Initialize()
        {

            array = new List<int>();
            array.Add(-1);
            array.Add(-2);
            array.Add(-3);
            array.Add(-7);
            array.Add(-17);
            array.Add(-27);
            array.Add(-18);
            array.Add(-541);
            array.Add(-8);
            array.Add(-7);
            array.Add(7);
        }
    }
}
