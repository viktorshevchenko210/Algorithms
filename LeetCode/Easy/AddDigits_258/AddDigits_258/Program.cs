using System;

namespace AddDigits_258
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            AddDigits(num);
        }

        static int AddDigits(int num)
        {
            while ((int)Math.Ceiling(Math.Log10(Math.Abs(num) + 0.5)) != 1 && num != 0)
            {
                var oldNum = num;
                var result = 0;
                while (oldNum != 0)
                {
                    var lastNumber = oldNum % 10;
                    result += lastNumber;
                    oldNum /= 10;
                }
                num = result;
            }

            return num;
        }
    }
}
