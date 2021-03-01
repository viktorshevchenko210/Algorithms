using System;

namespace ContainsDuplicate_219
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 1 };
            int k = 3;
            ContainsNearbyDuplicate(array, k);
        }

        static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                var current = nums[i];
                var next = nums[i + 1];

                if (Math.Abs(current - next) >= 3)
                    return false;
            }

            return true;
        }
    }
}
