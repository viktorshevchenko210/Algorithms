using System;

namespace TwoSumInputArrayIsSorted_167
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 7, 11, 15 };
            int target = 9;

            var result = TwoSum(numbers, target);
        }

        static int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];

            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;

            while(leftIndex < rightIndex)
            {
                var resultValue = numbers[leftIndex] + numbers[rightIndex];

                if(resultValue == target)
                {
                    result[0] = ++leftIndex;
                    result[1] = ++rightIndex;
                    return result;
                }
                else if(resultValue > target)
                {
                    rightIndex--;
                }
                else if(resultValue < target)
                {
                    leftIndex++;
                }
            }

            return result;
        }
    }
}
