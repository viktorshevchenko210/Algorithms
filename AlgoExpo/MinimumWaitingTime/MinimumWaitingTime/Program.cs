using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumWaitingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] queries = new int[] { 3, 2, 1, 2, 6 };
            var total = MinimumWaitingTime(queries);
            Console.WriteLine(total);
            Console.ReadLine();
        }

        public static int MinimumWaitingTime(int[] queries)
        {
            var total = 0;
            var numbersSum = 0;

            Array.Sort(queries);

            for(int i = 0; i < queries.Count(); i++)
            {
                if (i == 0)
                    continue;

                var left = queries[i - 1];
                numbersSum += left;
                total = total + numbersSum;
            }

            return total;
        }
    }
}
