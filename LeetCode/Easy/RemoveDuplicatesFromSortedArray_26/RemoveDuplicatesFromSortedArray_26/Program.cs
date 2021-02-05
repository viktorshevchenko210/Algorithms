using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedArray_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var length = RemoveDuplicates(ref nums);
            Console.WriteLine(length);
            Console.ReadLine();
        }

        public static int RemoveDuplicates(ref int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return 1;

            int index1 = 0;
            int index2 = 1;

            while(index2 <= nums.Length - 1)
            {
                if (nums[index1] == nums[index2])
                    index2++;
                else
                    nums[++index1] = nums[index2++];
            }

            return ++index1;
        }
    }
}
