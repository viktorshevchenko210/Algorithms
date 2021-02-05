using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementSrtStr_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //TIme complexity - O(n*m)
            //Space - O(1)

            string needle = "aaaa";
            string haystack = "aaa";
            strStr(haystack, needle);
        }



        static int strStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;

            int needleIndex = 0;

            int needleLength = needle.Length;

            for (int i = 0; i < haystack.Length; i++)
            {
                if(haystack[i] == needle[0])
                {
                    if (haystack.Length - i < needleLength)
                        return 0;

                    var a = haystack.Substring(i, needleLength);
                    if (a == needle)
                        return i;
                }
            }
       
            return -1;
        }
    }
}
