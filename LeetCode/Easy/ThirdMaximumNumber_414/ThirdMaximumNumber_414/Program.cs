using System;

namespace ThirdMaximumNumber_414
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 2, 2 };
            ThirdMax(nums);
        }

        static int ThirdMax(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            int step = 1;
            int max = 0;

            for(int i = 0; i < nums.Length - 1; i++)
            {
                var current = nums[i];
                var next = nums[i + 1];

                if(current > max || next > max)
                    max = Math.Max(current, next);

                if(current != next)
                {
                    step++;
                    if (step == 3)
                        return next;
                }
            }

            return max;
        }
    }
}
