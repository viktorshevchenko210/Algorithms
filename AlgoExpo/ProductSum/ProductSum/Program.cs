using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProductSum
{
    class Program
    {
        static List<object> array;

        static void Main(string[] args)
        {
            Initialize();
            ProductSum();
        }

        public static int ProductSum()
        {
            var result = ProductSum(array, 0, 1);
            return result;
        }

        public static int ProductSum(List<object> array, int result, int multiplier)
        {
            for(int i = 0; i < array.Count; i++)
            {
                if(array[i] is int)
                {
                    result += (int)array[i];
                    continue;
                }
                else
                {
                    result += ProductSum((List<object>)array[i], 0, multiplier + 1);
                }

            }

            return result * multiplier;
        }

        public static void Initialize()
        {
            array = new List<object>();
            array.Add(5);
            array.Add(2);

            List<object> first = new List<object>();
            first.Add(7);
            first.Add(-1);

            array.Add(first);

            array.Add(3);

            List<object> second = new List<object>();
            second.Add(6);

            List<object> third = new List<object>();
            third.Add(-13);
            third.Add(8);

            second.Add(third);

            second.Add(4);

            array.Add(second);
        }
    }
}
