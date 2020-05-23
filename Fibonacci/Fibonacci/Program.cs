using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var fact = factorial(4);
            //var a = FibonacciNumber(10);
            //FibonacciNumberMemoization(10000);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.ReadKey();
        }

        static int factorial(int i)
        {

            if (i == 1)
                return 1;

            return factorial(i - 1) * i;
        }

        public static ulong FibonacciNumber(uint which)
        {
            if (which == 1 || which == 2)
                return 1;

            return FibonacciNumber(which - 2) + FibonacciNumber(which - 1);
        }


        //public static ulong FibonacciNumberMemoization(uint which)
        //{
        //    if (which == 1 || which == 2)
        //        return 1;

        //    ulong[] array = new ulong[which];
        //    array[0] = 1;
        //    array[1] = 1;

        //    return FibonacciNumberMemoization(which, array);
        //}

        //private static ulong FibonacciNumberMemoization(uint which, ulong[] array)
        //{
        //    if (array[which - 3] == 0)
        //    {
        //        array[which - 3] = FibonacciNumberMemoization(which - 2, array);
        //    }

        //    if (array[which - 2] == 0)
        //    {
        //        array[which - 2] = FibonacciNumberMemoization(which - 1, array);
        //    }

        //    array[which - 1] = array[which - 3] + array[which - 2];
        //    return array[which - 1];
        //}
    }
}
