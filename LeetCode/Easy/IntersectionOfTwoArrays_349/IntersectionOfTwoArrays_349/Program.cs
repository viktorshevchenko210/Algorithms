using System;
using System.Collections.Generic;
using System.Linq;

namespace IntersectionOfTwoArrays_349
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 4, 9, 5 };
            int[] nums2 = new int[] { 9, 4, 9, 8, 4 };

            var result = Intersection(nums1, nums2);

        }

        static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> result = new HashSet<int>();

            HashSet<int> left = new HashSet<int>(nums1);

            for (int i = 0; i < nums2.Length; i++)
            {
                var current = nums2[i];

                if (left.Contains(current))
                    result.Add(current);
            }

            return result.ToArray();
        }
    }
}
