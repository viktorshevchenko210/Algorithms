using System;
using System.Numerics;

namespace FactorialTrailingZeroes_172
{
    class Program
    {
        static void Main(string[] args)
        {
            TrailingZeroes(13);
        }

        static int TrailingZeroes(int n)
        {
            long result = 1;

            for(int i = 1; i <= n; i++)
            {
                result *= i;
            }

            int zeroesCount = 0;


            while(result != 0)
            {
                if(result % 10 != 0)
                {
                    return zeroesCount;
                }
                else
                {
                    zeroesCount++;
                }

                result = result / 10;
            }
            

            return zeroesCount;
        }
    }
}
