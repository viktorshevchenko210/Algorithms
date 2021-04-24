using System;
using System.Collections.Generic;

namespace BinaryWatch_401
{
    class Program
    {
        static void Main(string[] args)
        {
            int turnedOn = 2;
            ReadBinaryWatch(turnedOn);
        }

        static IList<string> ReadBinaryWatch(int turnedOn)
        {
            List<string> results = new List<string>();

            for (int hour = 0; hour < 12; hour++) 
            {
                for(int minute = 0; minute < 60; minute++)
                {
                    if(BitCount(hour) + BitCount(minute) == turnedOn)
                    {
                        if(minute < 10)
                            results.Add(String.Format("{0}:0{1}", hour, minute));
                        else
                            results.Add(String.Format("{0}:{1}", hour, minute));

                    }
                }
            }

            return results;
        }

        static int BitCount(int n)
        {
            var count = 0;
            while (n != 0)
            {
                count++;
                n &= (n - 1); //walking through all the bits which are set to one
            }

            return count;
        }
    }
}
