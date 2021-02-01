using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.hackerrank.com/challenges/apple-and-orange/problem

            int[] apples = new int[] { 2, 3, -4 };
            int[] orange = new int[] { 3, -2, -4 };

            countApplesAndOranges(7, 10, 4, 12, apples, orange);

            Console.ReadKey();
        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int countApples = 0;
            foreach(var apple in apples)
            {
                var tmp = apple + a;
                if (tmp >= s && tmp <= t)
                    countApples++;
            }

            int countOranges = 0;
            foreach (var orange in oranges)
            {
                var tmp = orange + b;
                if (tmp >= s && tmp <= t)
                    countOranges++;
            }

            Console.WriteLine(countApples);
            Console.WriteLine(countOranges);

        }

    }
}
