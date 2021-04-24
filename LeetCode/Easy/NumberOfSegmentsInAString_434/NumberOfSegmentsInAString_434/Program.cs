using System;

namespace NumberOfSegmentsInAString_434
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "Hello, my name is John";
            string s = "";
            CountSegments(s);
        }

        static int CountSegments(string s)
        {
            int segments = 0;
            int wordLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] != '\0' && s[i] != ' ')
                {
                    wordLength++;
                }
                else
                {
                    if (wordLength != 0)
                        segments++;

                    wordLength = 0;
                }
            }

            if (wordLength != 0)
                segments++;

            return segments;
        }
    }
}
