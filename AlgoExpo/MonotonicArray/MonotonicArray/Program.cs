using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonotonicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];
            Initialize(array);
            var isMonotonic = IsMonotonic(array);
        }

        static bool IsMonotonic(int[] array)
        {
            if (array.Length <= 2)
                return true;

            bool isAsc = false;

            if (array[0] < array[1])
                isAsc = true;

            for(int i = 0; i < array.Length-1; i++)
            {
                if (isAsc)
                {
                    if (array[i] < array[i + 1])
                        continue;
                    else
                        return true;
                }
                else
                {

                    if (array[i] > array[i + 1])
                        continue;
                    else
                        return true;
                }
            }

            return false;
        }

        static void Initialize(int[] array)
        {
            array[0] = -1;
            array[1] = -5;
            array[2] = -10;
            array[3] = -1100;
            array[4] = -1100;
            array[5] = -1101;
            array[6] = -1102;
            array[7] = -9001;
        }
    }
}
