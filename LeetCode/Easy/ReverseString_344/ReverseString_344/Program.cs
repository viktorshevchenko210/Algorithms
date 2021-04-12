using System;

namespace ReverseString_344
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = new char[]{ 'h', 'e', 'l', 'l', 'o' };
            ReverseString(s);
        }

        static void ReverseString(char[] s)
        {
            var startPointer = 0;
            var endPointer = s.Length - 1;

            while (startPointer < endPointer)
            {
                Swap(s, startPointer, endPointer);
                startPointer++;
                endPointer--;
            }
        }

        static void Swap(char[]s, int startPointer, int endPointer)
        {
            var temp = s[startPointer];
            s[startPointer] = s[endPointer];
            s[endPointer] = temp;
        }
    }
}
