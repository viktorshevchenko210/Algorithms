using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LongestPeak
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[13];
            Initialize(array);
            var peak = Peak(array);
        }

        static int Peak(int[] array)
        {
            int longestPeakLegth = 0;
            int currentPeakLegth = 0;
            int i = 1;

            while(i < array.Length-1)
            {
                var previous = array[i - 1];
                var current = array[i];
                var next = array[i + 1];

                if (current > previous && current > next)
                {
                    currentPeakLegth = 1;

                    int leftIndex = i;
                    while(leftIndex != 0 && array[leftIndex] > array[leftIndex-1])
                    {
                        currentPeakLegth++;
                        leftIndex--;
                    }


                    int rightIndex = i;
                    while (rightIndex != array.Length-1 && array[rightIndex] > array[rightIndex+1])
                    {
                        currentPeakLegth++;
                        rightIndex++;
                    }

                    if (currentPeakLegth > longestPeakLegth)
                        longestPeakLegth = currentPeakLegth;

                    i++;
                    continue;
                }

                i++;
            }
    
            return longestPeakLegth;
        }

        static void Initialize(int[] array)
        {
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 3;
            array[4] = 4;
            array[5] = 0;
            array[6] = 10;
            array[7] = 6;
            array[8] = 5;
            array[9] = -1;
            array[10] = -3;
            array[11] = 2;
            array[12] = 3;
        }
    }
}
