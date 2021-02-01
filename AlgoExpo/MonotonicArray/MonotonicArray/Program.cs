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
            int[] array = new int[] { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 };
            var isMonotonic = IsMonotonic(array);
            Console.WriteLine(isMonotonic);
            Console.ReadKey();
        }

        public static bool IsMonotonic(int[] array)
        {
            if (array.Count() == 0 || array.Count() == 1)
                return true;

            bool isDeacrease = false;
            bool isIncrease = false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                var current = array[i];
                var next = array[i + 1];

                if (!isDeacrease && !isIncrease)
                {
                    if (current > next)
                        isDeacrease = true;
                    
                    if (current < next)
                        isIncrease = true;

                    continue;
                }

                if (isDeacrease)
                {
                    if (current < next)
                        return false;
                }

                if (isIncrease)
                {
                    if (current > next)
                        return false;
                }
            }

            return true;
        }


    }
}
