using System;
using System.Collections.Generic;

namespace SingleNUmber_136
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 2, 1 };
            SingleNumber(nums);
        }

        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                var current = nums[i];

                if (numbers.ContainsKey(current))
                {
                    numbers[current]++;
                }
                else
                {
                    numbers.Add(current, 1);
                }
            }

            foreach (var number in numbers)
            {
                if (number.Value == 1)
                    return number.Key;
            }

            return 0;

        }
    }
}
