using System;

namespace RepeatedSubstringPattern_459
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abaababaab";
            RepeatedSubstringPattern(s);
        }

        static bool RepeatedSubstringPattern(string s)
        {
            char first = s[0];

            string previousWord = "";
            string word = $"{first}";

            bool substringFound = false;

            for (int i = 1; i < s.Length; i++)
            {
                if(s[i] == first)
                {
                    if(substringFound)
                    {
                        if (word != previousWord)
                            return false;
                    }

                    previousWord = "";
                    substringFound = true;
                }

                if (substringFound)
                    previousWord += s[i];

                if (!substringFound)
                    word += s[i];
            }

            if (word != previousWord)
                return false;

            return true;
        }
    }
}
