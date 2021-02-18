using System;

namespace PlusOne_66
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[] { 9 };
            PlusOne(digits);
        }

        static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; --i)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] = digits[i] + 1;
                    return digits;
                }
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            Array.Copy(digits, 0, result, 1, digits.Length);
            return result;

            //var lastNumber = digits[digits.Length - 1] + 1;
            //var numbersCount = (int)Math.Ceiling(Math.Log10(Math.Abs(lastNumber) + 0.5));

            //if(numbersCount == 1)
            //{
            //    digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
            //    return digits;
            //}

            //int[] result = new int[digits.Length+numbersCount-1];

            //for(int i = 0; i < digits.Length - 1; i++) 
            //{
            //    result[i] = digits[i];
            //}

            //for (int i = result.Length-1; i >= digits.Length-1; i--)
            //{
            //    var j = lastNumber % 10;
            //    lastNumber = lastNumber / 10;
            //    result[i] = j;
            //}

            //return result;
        }
    }
}
