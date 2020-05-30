using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>(); ;
            Initialize(array);
            var list = Find(array, 0);
        }

        static List<List<int>> Find(List<int> source, int targetSum)
        {
            List<List<int>> result = new List<List<int>>();

            source = source.OrderBy(i=>i).ToList();

            int count = source.Count;

            for (int i = 0; i < source.Count; i++)
            {
                int left = i + 1;
                if (left >= count)
                    return result;

                int right = count - 1;

                while (left != right && right != 0)
                {
                    int sourceI = source[i];
                    int sourceLeft = source[left];
                    int sourceRight = source[right];
                    int sum = sourceI + sourceLeft + sourceRight;

                    if (sum == targetSum)
                    {
                        List<int> temp = new List<int>();
                        temp.Add(source[i]);
                        temp.Add(source[left]);
                        temp.Add(source[right]);
                        result.Add(temp);
                        right--;
                    }
                    else if (sum > targetSum)
                        right--;
                    else if (sum < targetSum)
                        left++;
                }
            }       
            return result;
        }

        static void Initialize(List<int> array)
        {
            array.Add(12);
            array.Add(3);
            array.Add(1);
            array.Add(2);
            array.Add(-6);
            array.Add(5);
            array.Add(-8);
            array.Add(6);
        }
    }
}
