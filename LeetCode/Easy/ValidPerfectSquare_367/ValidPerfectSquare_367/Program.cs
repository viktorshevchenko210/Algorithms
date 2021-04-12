using System;

namespace ValidPerfectSquare_367
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = IsPerfectSquare(2147483647);
        }

        static bool IsPerfectSquare(int num)
        {
            long left = 0;
            long right = num;

            while (left <= right)
            {
                long middle = (left + right) / 2;

                long sqrt = middle * middle;

                if (sqrt == num)
                    return true;
                else if(sqrt > num)
                {
                    right = middle - 1;
                }
                else if (sqrt < num)
                {
                    left = middle + 1;
                }
            }

            return false;
        }
    }
}
