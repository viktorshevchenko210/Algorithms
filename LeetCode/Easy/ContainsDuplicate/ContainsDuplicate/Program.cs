using System;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,2,3,1 };
            ContainsDuplicateMethod(nums);
        }

        static bool ContainsDuplicateMethod(int[] nums)
        {
            HashSet<int> saved = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (saved.Contains(nums[i]))
                    return true;
                else
                    saved.Add(nums[i]);
            }

            return false;
        }
    }
}
