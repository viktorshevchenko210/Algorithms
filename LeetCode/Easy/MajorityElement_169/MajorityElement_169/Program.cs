using System;

namespace MajorityElement_169
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 3 };
            var result = MajorityElement(nums);
        }

        static int MajorityElement(int[] nums)
        {
            int count = 0;
            int candidate = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if(count == 0)
                {
                    candidate = nums[i];
                }

                if(candidate == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return candidate;
        }
    }
}
