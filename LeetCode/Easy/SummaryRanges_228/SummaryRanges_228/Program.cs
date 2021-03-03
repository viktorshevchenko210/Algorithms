using System;
using System.Collections.Generic;

namespace SummaryRanges_228
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 2, 4, 5, 7 };
            SummaryRanges(array);
        }

        static IList<string> SummaryRanges(int[] nums)
        {
            List<string> result = new List<string>();
            int start = nums[0], end = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == end + 1)
                {
                    end = nums[i];
                }
                else
                {
                    if(end - start >= 1)
                    {
                        result.Add($"{start}->{end}");
                    }
                    else
                    {
                        result.Add($"{start}");
                    }

                    start = end = nums[i];
                }
            }

            if (end - start >= 1)
            {
                result.Add($"{start}->{end}");
            }

            else
            {
                result.Add($"{start}");
            }

            return result;
        }
    }
}
