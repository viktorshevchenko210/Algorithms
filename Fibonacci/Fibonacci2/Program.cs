using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Fibonacci(4);
            Console.WriteLine(a);
            Console.ReadKey();
        }

        static int Fibonacci(int num)
        {
            var list = new List<int>();

            var first = 1;
            var second = 2;

            for (int i = 0; i < num; i++)
            {

            }
        }
    }
}
