using System;

namespace MoveZeroes_283
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);
        }

        static void MoveZeroes(int[] nums)
        {
            int startIndex = 0;
            int secondIndex = 1;
            
            while (startIndex < nums.Length - 1 && secondIndex <= nums.Length - 1)
            {
                var current = nums[startIndex];
                var next = nums[secondIndex];

                if (current == 0)
                {
                    if(next == 0)
                    {
                        secondIndex++;
                    }
                    else
                    {
                        nums[startIndex] = next;
                        nums[secondIndex] = current;
                        secondIndex--;
                    }
                }
                else
                {
                    startIndex++;
                    secondIndex++;
                }
            }
        }
    }
}
