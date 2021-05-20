using System;

namespace LevenshteinDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abc";
            string str2 = "yabd";
            LevenshteinDistance(str1, str2);
        }

        public static int LevenshteinDistance(string str1, string str2)
        {
            string small = str1.Length < str2.Length ? str1 : str2;
            string big = str1.Length >= str2.Length ? str1 : str2;

            int[] evenEdits = new int[small.Length + 1];
            int[] oddEdits = new int[small.Length + 1];

            // Write your code here.
            return -1;
        }
    }
}
