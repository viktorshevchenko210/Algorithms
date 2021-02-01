using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RusLengthEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "........______=========AAAA   AAABBBB   BBB";
            string result = RunLengthEncodingMethod(input);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static string RunLengthEncodingMethod(string str)
        {
            string result = "";
            char symbol = str[0];

            var count = 0;

            for(int i = 1; i < str.Length; i++)
            {
                char current = str[i];
                char previous = str[i - 1];

                if((current != previous) || count == 9)
                {
                    result += $"{count}{previous}";
                    count = 0;
                }
                count +=1;
            }

            result += $"{count}{str[str.Length - 1]}";

            return result;
        }
    }
}
