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
            List<string> ranges = new List<string>();

            bool isRange = false;

            int steps = 0;
            int startRange = 0;

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                var current = nums[i];
                var next = nums[i + 1];

                if(next - current == 1)
                {
                    if (isRange)
                    {
                        steps++;
                        continue;
                    }
                    startRange = current;
                    isRange = true;
                }
                else
                {
                    if (isRange)
                    {
                        if(steps > 0)
                        {
                            ranges.Add($"{startRange}->{current}");
                        }
                        else
                        {
                            ranges.Add($"{startRange}");
                        }
                        isRange = false;
                    }
                    else
                    {
                        ranges.Add($"{current}");
                    }
                }
            }

            return ranges;
        }
    }
}
