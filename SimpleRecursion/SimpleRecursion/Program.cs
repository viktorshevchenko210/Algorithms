using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursion(4);
            Console.ReadKey();
        }

        static void Recursion(int counter)
        {
            counter--;

            Console.WriteLine($"A: {counter}");


            if (counter != 0)
                Recursion(counter);

            Console.WriteLine($"B: {counter}");
        }
    }
}
