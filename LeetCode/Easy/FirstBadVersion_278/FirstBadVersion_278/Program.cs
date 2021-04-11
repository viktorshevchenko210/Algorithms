using System;

namespace FirstBadVersion_278
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            var a = FirstBadVersion(n);
        }

        static int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (isBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }

        static bool isBadVersion(int version)
        {
            if (version <= 3)
                return false;

            return true;
        }
    }
}
