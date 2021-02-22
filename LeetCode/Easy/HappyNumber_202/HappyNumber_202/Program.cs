using System;
using System.Collections.Generic;

namespace HappyNumber_202
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            var isHappy = IsHappy(n);

            Console.WriteLine(isHappy);
            Console.ReadKey();
        }

        static bool IsHappy(int n)
        {
            HashSet<int> numbers = new HashSet<int>();

            while (true)
            {
                var nNew = 0;

                while(n > 0)
                {
                    var i = n % 10;
                    nNew += i * i;

                    n = n / 10;
                }

                if (nNew == 1)
                    return true;

                n = nNew;

                if (numbers.Contains(n))
                    return false;
                else
                    numbers.Add(n);
            }
        }
    }
}
