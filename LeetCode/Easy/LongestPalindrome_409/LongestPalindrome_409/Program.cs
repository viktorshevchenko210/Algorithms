using System;
using System.Collections.Generic;

namespace LongestPalindrome_409
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "bananas";
            LongestPalindrome(s);
        }

        static int LongestPalindrome(string s)
        {

            Dictionary<char, int> charAndCount = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (charAndCount.ContainsKey(s[i]))
                    charAndCount[s[i]]++;
                else
                    charAndCount.Add(s[i], 1);
            }

            var length = 0;

            foreach (var keyValuePair in charAndCount)
            {
                var key = keyValuePair.Key;
                var value = keyValuePair.Value;

                length += value / 2 * 2;

                if (length % 2 == 0 && value % 2 == 1)
                    length++;
    
            }

            return length;
        }
    }
}
