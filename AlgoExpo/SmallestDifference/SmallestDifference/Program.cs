using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = new int[6];
            int[] second = new int[5];
            Initialize(first, second);
            var result = SmallestDifference(first, second);
        }

        private static int[] SmallestDifference(int[] first, int[] second)
        {
            Array.Sort(first);
            Array.Sort(second);

            int[] result = new int[2];

            var firstLength = first.Length;
            var secondLength = second.Length;

            var firstCounter = 0;
            var secondCounter = 0;

            var smallestDifference = Int32.MaxValue;

            while (firstLength != firstCounter && secondLength != secondCounter)
            {
                var left = first[firstCounter];
                var right = second[secondCounter];

                var currentDifference = Math.Abs(left - right);

                if (currentDifference < smallestDifference)
                {
                    smallestDifference = currentDifference;
                    result[0] = left;
                    result[1] = right;
                }

                if (left < right)
                    firstCounter++;
                else
                    secondCounter++;
                

            }

            return result;
        }


        static void Initialize(int[] first, int[] second)
        {
            first[0] = -1;
            first[1] = 5;
            first[2] = 10;
            first[3] = 20;
            first[4] = 28;
            first[5] = 3;

            second[0] = 26;
            second[1] = 134;
            second[2] = 135;
            second[3] = 15;
            second[4] = 17;
        }
    }
}
