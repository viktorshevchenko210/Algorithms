using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLastWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "day     ";
            var length = LengthOfLastWord(input);
            Console.WriteLine(length);
            Console.ReadLine();
        }

        public static int LengthOfLastWord(string s)
        {
            int length = 0;

            int startIndex = 0;
            int endIndex = s.Length - 1;

            while (startIndex <= endIndex)
            {
                if (s[endIndex] == ' ')
                {
                    endIndex--;
                    continue;
                }

                if (s[startIndex] != ' ')
                {
                    startIndex++;
                    length++;
                }
                else
                {
                    length = 0;
                    startIndex++;
                }

            }

            return length;
        }
    }
}
