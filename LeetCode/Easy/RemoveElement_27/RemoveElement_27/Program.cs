using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;

            var length = RemoveElement(ref nums, val);
            Console.WriteLine(length);
            Console.ReadLine();
        }

        public static int RemoveElement(ref int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int start = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[start++] = nums[i];
                }
            }

            return start;
        }
    }
}
