using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 121;
            var isPalindrome = IsPalindrome(x);
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            var result = 0;
            var originalNumber = x;

            while (x != 0)
            {
                result = result * 10 + (x % 10);
                x = x / 10;
            }

            if(result - originalNumber == 0)
                return true;

            return false;
        }
    }
}
