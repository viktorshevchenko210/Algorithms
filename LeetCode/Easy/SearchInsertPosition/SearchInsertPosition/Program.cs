using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 5;
            SearchInsert(nums, target);
        }

        static int SearchInsert(int[] nums, int target)
        {
            int startIndex = 0;
            int endIndex = nums.Length - 1;

            int middleIndex = 0;
            
            while (startIndex <= endIndex)
            {
                middleIndex = (startIndex + endIndex) / 2;

                if (nums[middleIndex] == target)
                    return middleIndex;
                else if (nums[middleIndex] < target)
                    startIndex = middleIndex + 1;
                else
                    endIndex = middleIndex - 1;

            }

            if (nums[middleIndex] < target)
                return ++middleIndex;
            else
                return middleIndex;
        }
    }
}
