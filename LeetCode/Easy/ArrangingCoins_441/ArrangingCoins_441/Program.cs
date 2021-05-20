using System;

namespace ArrangingCoins_441
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrangeCoins(5);
        }

        static int ArrangeCoins(int n)
        {
            int completedRow = 0;

            int row = 1;

            while(n >= 0)
            {
                n = n - row;
                if (n < 0)
                    return completedRow;

                completedRow++;
                row++;
            }

            return completedRow;
        }
    }
}
