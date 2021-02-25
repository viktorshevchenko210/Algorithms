using System;
using System.Collections.Generic;

namespace CountPrimes_204
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 499979;
            CountPrimes(n);
        }

        static int CountPrimes(int n)
        {
            HashSet<int> excluded = new HashSet<int>();

            int count = 0;

            int i = 2;

            while (i <= n)
            {
                if (!excluded.Contains(i))
                {
                    int index = 0;

                    int cur = i * i;

                    for (int j = cur; j <= n; j = cur + index * i)
                    {
                        excluded.Add(j);
                        index++;
                    }

                    count++;
                }

                i++;
            }
            return count;
        }
    }
}
