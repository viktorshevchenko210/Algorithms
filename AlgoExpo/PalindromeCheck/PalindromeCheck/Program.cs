using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    class Program
    {

        static void Main(string[] args)
        {
            string palindrom = "abcdefghhgfedcba";
            Check(palindrom);
        }


        static bool Check(string palindrom)
        {
            int left = 0;
            int right = palindrom.Length - 1;

            while (left < right)
            {
                if (palindrom[left] != palindrom[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
