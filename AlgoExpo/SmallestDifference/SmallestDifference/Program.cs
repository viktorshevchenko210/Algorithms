using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = new int[6];
            int[] second = new int[5];
            Initialize(first, second);
            var result = SmallestDifference(first, second);
        }

        static int[] SmallestDifference(int[] first, int[] second)
        {
            int[] result = new int[2];

            first = first.OrderBy(i => i).ToArray();
            second = second.OrderBy(i => i).ToArray();

            int left = 0;
            int right = 0;

            while(left != first.Length || right != second.Length)
            {
                if(first[left] == second[right])
                {
                    result[0] = first[left];
                    result[1] = second[right];
                    return result;
                }
                else if(first[left] > second[right])
                {
                    if ()
                    {

                    }
                    second++;
                }
                else if(first[left] < second[right])
                {
                    left++;
                }
            }

            return result;
        }

        static void Initialize(int[] first, int[] second)
        {
            first[0] = -1;
            first[1] = 5;
            first[2] = 10;
            first[3] = 20;
            first[4] = 28;
            first[5] = 3;

            second[0] = 26;
            second[1] = 134;
            second[2] = 135;
            second[3] = 15;
            second[4] = 17;
        }
    }
}
